using GerenciadorContatos.Aplicacao;
using GerenciadorContatos.Aplicacao.Abstracoes.Excecoes;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Aplicacao.Excecoes;
using GerenciadorContatos.Dominio;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorContatos
{
    public partial class SequenciaNumericaEditForm : Form
    {

        private readonly IErrorHandler _errorHandler;
        private readonly InformacaoPagina _informacaoPagina;
        private readonly ICongregacaoServico _CongregacaoServico;
        private readonly IOperadoraServico _operadoraServico;
        private readonly SequenciaNumerica _sequenciaNumerica;

        public SequenciaNumericaEditForm()
        {
            InitializeComponent();
        }
        public SequenciaNumericaEditForm(SequenciaNumerica sequenciaNumerica)
        {
            _sequenciaNumerica = sequenciaNumerica;
            _sequenciaNumerica.BeginEdit();

            _errorHandler = InjecaoDependencia.GetService<IErrorHandler>();

            _informacaoPagina = InjecaoDependencia.GetService<InformacaoPagina>();
            _informacaoPagina.Tamanho = int.MaxValue - 1;

            _CongregacaoServico = InjecaoDependencia.GetService<ICongregacaoServico>();
            _operadoraServico = InjecaoDependencia.GetService<IOperadoraServico>();

            InitializeComponent();
        }

        private async Task CarregaDadosAsync()
        {
            try
            {
                BindHelper.SuspendBinding(SequenciaNumericaBindingSource);
                BindHelper.ClearDataSource(CmbCongregacao, CongregacaoBindingSource);
                BindHelper.ClearDataSource(CmbOperadora, OperadoraBindingSource);

                var congregacaoContainerDados = await _CongregacaoServico.ObterAsync(informacaoPagina: _informacaoPagina);
                CongregacaoBindingSource.DataSource = AutoMapeamento.Map<BindingList<Congregacao>>(congregacaoContainerDados.Dados);

                var operadoraContainerDados = await _operadoraServico.ObterAsync(informacaoPagina: _informacaoPagina);
                OperadoraBindingSource.DataSource = AutoMapeamento.Map<BindingList<Operadora>>(operadoraContainerDados.Dados);

                SequenciaNumericaBindingSource.DataSource = _sequenciaNumerica;
            }
            finally
            {
                BindHelper.SetDataSource(CmbCongregacao, nameof(Congregacao.Id), nameof(Congregacao.Nome), CongregacaoBindingSource);
                BindHelper.SetDataSource(CmbOperadora, nameof(Operadora.Id), nameof(Operadora.Nome), OperadoraBindingSource);
                BindHelper.ResumeBinding(SequenciaNumericaBindingSource);
            }
        }

        private void SequenciaNumericaEditForm_Load(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(), _errorHandler);
        }

        private string MensagemErros()
        {
            var mensagemErros = new StringBuilder();

            var mensagemErro = CustomErrorProvider.GetError(CmbCongregacao);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);

            mensagemErro = CustomErrorProvider.GetError(CmbOperadora);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);

            mensagemErro = CustomErrorProvider.GetError(TxtPreFixo);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);

            mensagemErro = CustomErrorProvider.GetError(TxtInicio);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);

            mensagemErro = CustomErrorProvider.GetError(TxtFim);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);

            mensagemErro = CustomErrorProvider.GetError(TxtQuantidade);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);

            return mensagemErros.ToString();
        }

        private void BtnConfirma_Click(object sender, System.EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show(MensagemErros(), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SequenciaNumericaBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancela_Click(object sender, System.EventArgs e)
        {
            SequenciaNumericaBindingSource.CancelEdit();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CmbCongregacao_Validating(object sender, CancelEventArgs e)
        {
            if (CmbCongregacao.SelectedValue == null)
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(CmbCongregacao, "A escolha da associação é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(CmbCongregacao, string.Empty);
        }

        private void CmbOperadora_Validating(object sender, CancelEventArgs e)
        {
            if (CmbOperadora.SelectedValue == null)
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(CmbOperadora, "A escolha da operadora é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(CmbOperadora, string.Empty);
        }

        private void TxtCodigoArea_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCodigoArea.Text))
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(TxtPreFixo, "A digitação do código da área é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(TxtPreFixo, string.Empty);
        }

        private void TxtPreFixo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtPreFixo.Text))
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(TxtPreFixo, "A digitação do pré-fixo é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(TxtPreFixo, string.Empty);
        }

        private void TxtInicio_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(TxtInicio.Text, out int codigo) || codigo < 0)
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(TxtInicio, "A digitação do número inicial é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(TxtInicio, string.Empty);
        }

        private void TxtFim_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(TxtFim.Text, out int codigo) || codigo <= 0)
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(TxtFim, "A digitação do número final é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(TxtFim, string.Empty);
        }

        private void TxtQuantidade_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(TxtQuantidade.Text, out int codigo) || codigo <= 0)
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(TxtQuantidade, "A digitação da quantidade de número telefônicos por cartão é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(TxtQuantidade, string.Empty);
        }

        private void SequenciaNumericaEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(SequenciaNumericaBindingSource);
            BindHelper.SuspendBinding(CongregacaoBindingSource);
            BindHelper.SuspendBinding(OperadoraBindingSource);
        }
    }
}
