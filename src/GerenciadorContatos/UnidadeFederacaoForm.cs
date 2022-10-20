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
    public partial class UnidadeFederacaoForm : Form
    {
        private readonly IErrorHandler _errorHandler;
        private readonly InformacaoPagina _informacaoPagina;
        private readonly IUnidadeFederacaoServico _unidadeFederacaoServico;

        public UnidadeFederacaoForm()
        {
            _errorHandler = InjecaoDependencia.GetService<IErrorHandler>();
            _informacaoPagina = InjecaoDependencia.GetService<InformacaoPagina>();
            _unidadeFederacaoServico = InjecaoDependencia.GetService<IUnidadeFederacaoServico>();
            InitializeComponent();
        }

        private async Task CarregaDadosAsync()
        {
            BindHelper.SuspendBinding(UnidadeFederacaoBindingSource);
            try
            {
                var containerDados = await _unidadeFederacaoServico.ObterAsync(informacaoPagina: _informacaoPagina, orderBy: nameof(UnidadeFederacao.Nome));
                UnidadeFederacaoBindingSource.DataSource = AutoMapeamento.Map<BindingList<UnidadeFederacao>>(containerDados.Dados);
            }
            finally
            {
                BindHelper.ResumeBinding(UnidadeFederacaoBindingSource);
            }
        }

        private void UnidadeFederacaoForm_Load(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(), _errorHandler);
        }

        private void UnidadeFederacaoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(UnidadeFederacaoBindingSource);
        }

        private async Task AdicionaItemAsync()
        {
            var item = new UnidadeFederacao();
            using (var form = new UnidadeFederacaoEditForm(item))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    item.Id = await _unidadeFederacaoServico.InserirAsync(item);
                    UnidadeFederacaoBindingSource.Add(item);
                    UnidadeFederacaoBindingSource.MoveLast();
                }
            }
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(AdicionaItemAsync(), _errorHandler);
        }

        private void UnidadeFederacaoBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate
                            && e.Exception == null)
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }

        private async Task ApagaItemAsync()
        {
            var item = (UnidadeFederacao)UnidadeFederacaoBindingSource.Current;
            if (MessageBox.Show(this, $"Confirma a exclusão da unidade da federação: {item.Nome}", "Gerenciador contatos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await _unidadeFederacaoServico.ExcluirAsync(item);
                UnidadeFederacaoBindingSource.RemoveCurrent();
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(ApagaItemAsync(), _errorHandler);
        }

        private async Task AlterarItemAsync()
        {
            var item = (UnidadeFederacao)UnidadeFederacaoBindingSource.Current;
            using (var form = new UnidadeFederacaoEditForm(item))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    UnidadeFederacaoBindingSource.EndEdit();
                    item = (UnidadeFederacao)UnidadeFederacaoBindingSource.Current;
                    await _unidadeFederacaoServico.AtualizarAsync(item);
                }
                else
                {
                    UnidadeFederacaoBindingSource.CancelEdit();
                }
            }
        }

        private void AlterarToolStripButton_Click(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(AlterarItemAsync(), _errorHandler);
        }

        private void PaginaAnteriorStripButton_Click(object sender, EventArgs e)
        {
            if (_informacaoPagina.Indice > 1)
            {
                _informacaoPagina.Indice--;
                TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(), _errorHandler);
            }
        }

        private void ProximaPaginaStripButton_Click(object sender, EventArgs e)
        {
            if (_informacaoPagina.TemMaisPaginas)
            {
                _informacaoPagina.Indice++;
                TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(), _errorHandler);
            }
        }
    }
}
