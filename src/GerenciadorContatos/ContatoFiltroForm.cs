using GerenciadorContatos.Aplicacao;
using GerenciadorContatos.Aplicacao.Abstracoes.Excecoes;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Aplicacao.Excecoes;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Dominio.Dtos;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorContatos
{
    public partial class ContatoFiltroForm : Form
    {

        private readonly IErrorHandler _errorHandler;
        private readonly InformacaoPagina _informacaoPagina;
        private readonly IOperadoraServico _operadoraServico;
        private readonly ISimNaoServico _simNaoServico;
        private readonly ContatoFiltroDto _contatoFiltroDto;

        public ContatoFiltroForm()
        {
            InitializeComponent();
        }

        public ContatoFiltroForm(ContatoFiltroDto cartaoFiltroDto)
        {
            _contatoFiltroDto = cartaoFiltroDto;
            _contatoFiltroDto.BeginEdit();

            _errorHandler = InjecaoDependencia.GetService<IErrorHandler>();

            _informacaoPagina = InjecaoDependencia.GetService<InformacaoPagina>();
            _informacaoPagina.Tamanho = int.MaxValue - 1;

            _operadoraServico = InjecaoDependencia.GetService<IOperadoraServico>();
            _simNaoServico = InjecaoDependencia.GetService<ISimNaoServico>();

            InitializeComponent();
        }

        private async Task CarregaDadosAsync()
        {
            try
            {
                BindHelper.SuspendBinding(ContatoBindingSource);
                BindHelper.ClearDataSource(CmbOperadora, OperadoraBindingSource);
                BindHelper.ClearDataSource(CmbPermiteLigar, SimNaoBindingSource);

                var operadoraContainerDados = await _operadoraServico.ObterAsync(informacaoPagina: _informacaoPagina, orderBy: nameof(Operadora.Nome));
                OperadoraBindingSource.DataSource = AutoMapeamento.Map<BindingList<Operadora>>(operadoraContainerDados.Dados);

                var simNaoContainerDados = await _simNaoServico.ObterAsync(informacaoPagina: _informacaoPagina, orderBy: nameof(SimNao.Id));
                SimNaoBindingSource.DataSource = AutoMapeamento.Map<BindingList<SimNao>>(simNaoContainerDados.Dados);

                ContatoBindingSource.DataSource = _contatoFiltroDto;
            }
            finally
            {
                BindHelper.SetDataSource(CmbOperadora, nameof(Operadora.Id), nameof(Operadora.Nome), OperadoraBindingSource);
                BindHelper.SetDataSource(CmbPermiteLigar, nameof(SimNao.Valor), nameof(SimNao.Texto), SimNaoBindingSource);
                BindHelper.ResumeBinding(ContatoBindingSource);
            }
        }

        private void CartaoEditForm_Load(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(), _errorHandler);
        }

        private string MensagemErros()
        {
            var mensagemErros = new StringBuilder();

            var mensagemErro = CustomErrorProvider.GetError(CmbOperadora);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);

            mensagemErro = CustomErrorProvider.GetError(TxtNumeroTelefone);
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

            if (CmbPermiteLigar.SelectedIndex <= 0)
                _contatoFiltroDto.PermiteLigar = null;

            if (CmbPermiteLigar.SelectedIndex == 1)
                _contatoFiltroDto.PermiteLigar = true;

            if (CmbPermiteLigar.SelectedIndex == 2)
                _contatoFiltroDto.PermiteLigar = false;

            ContatoBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancela_Click(object sender, System.EventArgs e)
        {
            ContatoBindingSource.CancelEdit();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnCmbOperadoraLimpar_Click(object sender, System.EventArgs e)
        {
            CmbOperadora.SelectedIndex = -1;
        }

        private void ContatoFiltroForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(ContatoBindingSource);
            BindHelper.SuspendBinding(OperadoraBindingSource);
            BindHelper.SuspendBinding(SimNaoBindingSource);
        }
    }
}
