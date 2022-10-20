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
    public partial class SequenciaNumericaForm : Form
    {
        private readonly IErrorHandler _errorHandler;
        private readonly InformacaoPagina _informacaoPagina;
        private readonly InformacaoPagina _informacaoPaginaSequenciaNumerica;
        private readonly ICongregacaoServico _congregacaoServico;
        private readonly IOperadoraServico _operadoraServico;
        private readonly ISequenciaNumericaServico _sequenciaNumericaServico;

        public SequenciaNumericaForm()
        {
            _errorHandler = InjecaoDependencia.GetService<IErrorHandler>();

            _informacaoPagina = InjecaoDependencia.GetService<InformacaoPagina>();
            _informacaoPagina.Tamanho = int.MaxValue - 1;

            _informacaoPaginaSequenciaNumerica = InjecaoDependencia.GetService<InformacaoPagina>();

            _congregacaoServico = InjecaoDependencia.GetService<ICongregacaoServico>();
            _operadoraServico = InjecaoDependencia.GetService<IOperadoraServico>();
            _sequenciaNumericaServico = InjecaoDependencia.GetService<ISequenciaNumericaServico>();

            InitializeComponent();
        }

        private async Task CarregaDadosAsync(bool sequenciaNumerica = false, bool congregacao = false, bool operadora = false)
        {
            if (sequenciaNumerica)
                BindHelper.SuspendBinding(SequenciaNumericaBindingSource);
            if (congregacao)
                BindHelper.SuspendBinding(CongregacaoBindingSource);
            if (operadora)
                BindHelper.SuspendBinding(OperadoraBindingSource);
            try
            {
                if (congregacao)
                {
                    var congregacaoContainerDados = await _congregacaoServico.ObterAsync(informacaoPagina: _informacaoPagina);
                    CongregacaoBindingSource.DataSource = AutoMapeamento.Map<BindingList<Congregacao>>(congregacaoContainerDados.Dados);
                }
                if (operadora)
                {
                    var operadoraContainerDados = await _operadoraServico.ObterAsync(informacaoPagina: _informacaoPagina);
                    OperadoraBindingSource.DataSource = AutoMapeamento.Map<BindingList<Operadora>>(operadoraContainerDados.Dados);
                }
                if (sequenciaNumerica)
                {
                    var sequenciaNumericaContainerDados = await _sequenciaNumericaServico.ObterAsync(informacaoPagina: _informacaoPaginaSequenciaNumerica);
                    SequenciaNumericaBindingSource.DataSource = AutoMapeamento.Map<BindingList<SequenciaNumerica>>(sequenciaNumericaContainerDados.Dados);
                }
            }
            finally
            {
                BindHelper.ResumeBinding(CongregacaoBindingSource);
                BindHelper.ResumeBinding(OperadoraBindingSource);
                BindHelper.ResumeBinding(SequenciaNumericaBindingSource);
            }
        }

        private void SequenciaNumericaForm_Load(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, true, true), _errorHandler);
        }

        private void SequenciaNumericaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(SequenciaNumericaBindingSource);
            BindHelper.SuspendBinding(CongregacaoBindingSource);
            BindHelper.SuspendBinding(OperadoraBindingSource);
        }

        private void SequenciaNumericaBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate
                && e.Exception == null)
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }
        private async Task AdicionaItemAsync()
        {
            var item = new SequenciaNumerica();
            using (var form = new SequenciaNumericaEditForm(item))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await CarregaDadosAsync(false, true, true);
                    item.Id = await _sequenciaNumericaServico.InserirAsync(item);
                    SequenciaNumericaBindingSource.Add(item);
                    SequenciaNumericaBindingSource.MoveLast();
                }
            }
        }

        private void BindingNavigatorAddNewItem_Click(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(AdicionaItemAsync(), _errorHandler);
        }

        private async Task ApagaItemAsync()
        {
            var item = (SequenciaNumerica)SequenciaNumericaBindingSource.Current;
            if (MessageBox.Show(this, $"Confirma a exclusão da sequência numérica: {item.PreFixo} - {item.Inicio} - {item.Fim}", "Gerenciador contatos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await _sequenciaNumericaServico.ExcluirAsync(item);
                SequenciaNumericaBindingSource.RemoveCurrent();
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(ApagaItemAsync(), _errorHandler);

        }
        private async Task AlterarItemAsync()
        {
            var item = (SequenciaNumerica)SequenciaNumericaBindingSource.Current;
            await CarregaDadosAsync(false, true, true);
            using (var form = new SequenciaNumericaEditForm(item))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    SequenciaNumericaBindingSource.EndEdit();
                    item = (SequenciaNumerica)SequenciaNumericaBindingSource.Current;
                    await _sequenciaNumericaServico.AtualizarAsync(item);
                }
                else
                {
                    SequenciaNumericaBindingSource.CancelEdit();
                }
            }
        }

        private void AlterarToolStripButton_Click(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(AlterarItemAsync(), _errorHandler);
        }

        private void PaginaAnteriorStripButton_Click(object sender, System.EventArgs e)
        {
            if (_informacaoPaginaSequenciaNumerica.Indice > 1)
            {
                _informacaoPaginaSequenciaNumerica.Indice--;
                TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, false, false), _errorHandler);
            }
        }

        private void ProximaPaginaStripButton_Click(object sender, System.EventArgs e)
        {
            if (_informacaoPaginaSequenciaNumerica.TemMaisPaginas)
            {
                _informacaoPaginaSequenciaNumerica.Indice++;
                TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, false, false), _errorHandler);
            }
        }

        private async Task GerarDadosAsync()
        {
            try
            {
                await _sequenciaNumericaServico.GerarDadosAsync();
                MessageBox.Show("Geração dos cartões e contatos concluída com sucesso!", "Gerenciador contatos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        private void GerarCartoesContatosToolStripButton_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Confirma geração dos cartões e contatos para as sequências numéricas?", "Gerenciador contatos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TaskUtilities.FireAndForgetSafeAsync(GerarDadosAsync(), _errorHandler);
            }
        }
    }
}
