using GerenciadorContatos.Aplicacao;
using GerenciadorContatos.Aplicacao.Abstracoes.Excecoes;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Aplicacao.Excecoes;
using GerenciadorContatos.Dominio;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorContatos
{
    public partial class CongregacaoForm : Form
    {
        private readonly IErrorHandler _errorHandler;
        private readonly InformacaoPagina _informacaoPaginMunicipio;
        private readonly InformacaoPagina _informacaoPaginaCongregacao;
        private readonly IMunicipioServico _municipioServico;
        private readonly ICongregacaoServico _congregacaoServico;

        public CongregacaoForm()
        {
            _errorHandler = InjecaoDependencia.GetService<IErrorHandler>();
            _informacaoPaginMunicipio = InjecaoDependencia.GetService<InformacaoPagina>();
            _informacaoPaginMunicipio.Tamanho = int.MaxValue - 1;
            _informacaoPaginaCongregacao = InjecaoDependencia.GetService<InformacaoPagina>();
            _municipioServico = InjecaoDependencia.GetService<IMunicipioServico>();
            _congregacaoServico = InjecaoDependencia.GetService<ICongregacaoServico>();
            InitializeComponent();
        }
        private async Task CarregaDadosAsync(bool congregacao = false, bool municipio = false)
        {
            if (congregacao)
                BindHelper.SuspendBinding(CongregacaoBindingSource);
            if (municipio)
                BindHelper.SuspendBinding(MunincipioBindingSource);
            try
            {
                if (municipio)
                {
                    var munincipioContainerDados = await _municipioServico.ObterAsync(informacaoPagina: _informacaoPaginMunicipio);
                    MunincipioBindingSource.DataSource = AutoMapeamento.Map<BindingList<Municipio>>(munincipioContainerDados.Dados);
                }
                if (congregacao)
                {
                    var congregacaoContainerDados = await _congregacaoServico.ObterAsync(informacaoPagina: _informacaoPaginaCongregacao);
                    CongregacaoBindingSource.DataSource = AutoMapeamento.Map<BindingList<Congregacao>>(congregacaoContainerDados.Dados);
                }
            }
            finally
            {
                if (municipio)
                    BindHelper.ResumeBinding(MunincipioBindingSource);
                if (congregacao)
                    BindHelper.ResumeBinding(CongregacaoBindingSource);
            }
        }
        private void CongregacaoForm_Load(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, true), _errorHandler);
        }

        private void CongregacaoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(CongregacaoBindingSource);
            BindHelper.SuspendBinding(MunincipioBindingSource);
        }

        private async Task AdicionaItemAsync()
        {
            var item = new Congregacao();
            using (var form = new CongregacaoEditForm(item))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await CarregaDadosAsync(false, true);
                    item.Id = await _congregacaoServico.InserirAsync(item);
                    CongregacaoBindingSource.Add(item);
                    CongregacaoBindingSource.MoveLast();
                }
            }
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(AdicionaItemAsync(), _errorHandler);
        }

        private void CongregacaoBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate
                            && e.Exception == null)
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }
        private async Task ApagaItemAsync()
        {
            var item = (Congregacao)CongregacaoBindingSource.Current;
            if (MessageBox.Show(this, $"Confirma a exclusão da associação: {item.Nome}", "Gerenciador contatos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await _congregacaoServico.ExcluirAsync(item);
                CongregacaoBindingSource.RemoveCurrent();
            }
        }
        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(ApagaItemAsync(), _errorHandler);
        }
        private async Task AlterarItemAsync()
        {
            var item = (Congregacao)CongregacaoBindingSource.Current;
            await CarregaDadosAsync(false, true);
            using (var form = new CongregacaoEditForm(item))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    CongregacaoBindingSource.EndEdit();
                    item = (Congregacao)CongregacaoBindingSource.Current;
                    await _congregacaoServico.AtualizarAsync(item);
                }
                else
                {
                    CongregacaoBindingSource.CancelEdit();
                }
            }
        }
        private void AlterarToolStripButton_Click(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(AlterarItemAsync(), _errorHandler);
        }

        private void PaginaAnteriorStripButton_Click(object sender, EventArgs e)
        {
            if (_informacaoPaginaCongregacao.Indice > 1)
            {
                _informacaoPaginaCongregacao.Indice--;
                TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, false), _errorHandler);
            }
        }

        private void ProximaPaginaStripButton_Click(object sender, EventArgs e)
        {
            if (_informacaoPaginaCongregacao.TemMaisPaginas)
            {
                _informacaoPaginaCongregacao.Indice++;
                TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, false), _errorHandler);
            }
        }
    }
}
