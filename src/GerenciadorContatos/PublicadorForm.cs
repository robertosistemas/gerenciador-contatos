using GerenciadorContatos.Aplicacao;
using GerenciadorContatos.Aplicacao.Abstracoes.Excecoes;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Aplicacao.Excecoes;
using GerenciadorContatos.Dominio;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorContatos
{
    public partial class PublicadorForm : Form
    {
        private readonly IErrorHandler _errorHandler;
        private readonly InformacaoPagina _informacaoPaginaCongregacao;
        private readonly InformacaoPagina _informacaoPaginaPublicador;
        private readonly ICongregacaoServico _congregacaoServico;
        private readonly IPublicadorServico _publicadorServico;

        public PublicadorForm()
        {
            _errorHandler = InjecaoDependencia.GetService<IErrorHandler>();
            _informacaoPaginaCongregacao = InjecaoDependencia.GetService<InformacaoPagina>();
            _informacaoPaginaCongregacao.Tamanho = int.MaxValue - 1;
            _informacaoPaginaPublicador = InjecaoDependencia.GetService<InformacaoPagina>();
            _congregacaoServico = InjecaoDependencia.GetService<ICongregacaoServico>();
            _publicadorServico = InjecaoDependencia.GetService<IPublicadorServico>();
            InitializeComponent();
        }

        private async Task CarregaDadosAsync(bool publicador = false, bool congregacao = false)
        {
            if (publicador)
                BindHelper.SuspendBinding(PublicadorBindingSource);
            if (congregacao)
                BindHelper.SuspendBinding(CongregacaoBindingSource);
            try
            {
                if (congregacao)
                {
                    var congregacaoContainerDados = await _congregacaoServico.ObterAsync(informacaoPagina: _informacaoPaginaCongregacao);
                    CongregacaoBindingSource.DataSource = AutoMapeamento.Map<BindingList<Congregacao>>(congregacaoContainerDados.Dados);
                }
                if (publicador)
                {
                    var publicadorContainerDados = await _publicadorServico.ObterAsync(informacaoPagina: _informacaoPaginaPublicador, orderBy: nameof(Publicador.Nome));
                    PublicadorBindingSource.DataSource = AutoMapeamento.Map<BindingList<Publicador>>(publicadorContainerDados.Dados);
                }
            }
            finally
            {
                if (congregacao)
                    BindHelper.ResumeBinding(CongregacaoBindingSource);
                if (publicador)
                    BindHelper.ResumeBinding(PublicadorBindingSource);
            }
        }

        private void PublicadorForm_Load(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, true), _errorHandler);
        }

        private void PublicadorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(PublicadorBindingSource);
            BindHelper.SuspendBinding(CongregacaoBindingSource);
        }

        private void PublicadorBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate
                            && e.Exception == null)
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }

        private async Task AdicionaItemAsync()
        {
            var item = new Publicador();
            using (var form = new PublicadorEditForm(item))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await CarregaDadosAsync(false, true);
                    item.Id = await _publicadorServico.InserirAsync(item);
                    PublicadorBindingSource.Add(item);
                    PublicadorBindingSource.MoveLast();
                }
            }
        }

        private void BindingNavigatorAddNewItem_Click(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(AdicionaItemAsync(), _errorHandler);
        }

        private async Task AlterarItemAsync()
        {
            var item = (Publicador)PublicadorBindingSource.Current;
            await CarregaDadosAsync(false, true);
            using (var form = new PublicadorEditForm(item))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    PublicadorBindingSource.EndEdit();
                    item = (Publicador)PublicadorBindingSource.Current;
                    await _publicadorServico.AtualizarAsync(item);
                }
                else
                {
                    PublicadorBindingSource.CancelEdit();
                }
            }
        }

        private void AlterarToolStripButton_Click(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(AlterarItemAsync(), _errorHandler);
        }
        private async Task ApagaItemAsync()
        {
            var item = (Publicador)PublicadorBindingSource.Current;
            if (MessageBox.Show(this, $"Confirma a exclusão do publicador: {item.Nome}", "Gerenciador contatos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await _publicadorServico.ExcluirAsync(item);
                PublicadorBindingSource.RemoveCurrent();
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(ApagaItemAsync(), _errorHandler);
        }

        private void PaginaAnteriorStripButton_Click(object sender, System.EventArgs e)
        {
            if (_informacaoPaginaPublicador.Indice > 1)
            {
                _informacaoPaginaPublicador.Indice--;
                TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, false), _errorHandler);
            }
        }

        private void ProximaPaginaStripButton_Click(object sender, System.EventArgs e)
        {
            if (_informacaoPaginaPublicador.TemMaisPaginas)
            {
                _informacaoPaginaPublicador.Indice++;
                TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, false), _errorHandler);
            }
        }
    }
}
