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
    public partial class CartaoFiltroForm : Form
    {

        private readonly IErrorHandler _errorHandler;
        private readonly InformacaoPagina _informacaoPagina;
        private readonly ICongregacaoServico _congregacaoServico;
        private readonly IOperadoraServico _operadoraServico;
        private readonly IPublicadorServico _publicadorServico;
        private readonly ISimNaoServico _simNaoServico;
        private readonly CartaoFiltroDto _cartaoFiltroDto;

        public CartaoFiltroForm()
        {
            InitializeComponent();
        }

        public CartaoFiltroForm(CartaoFiltroDto cartaoFiltroDto)
        {
            _cartaoFiltroDto = cartaoFiltroDto;
            _cartaoFiltroDto.BeginEdit();

            _errorHandler = InjecaoDependencia.GetService<IErrorHandler>();

            _informacaoPagina = InjecaoDependencia.GetService<InformacaoPagina>();
            _informacaoPagina.Tamanho = int.MaxValue - 1;

            _congregacaoServico = InjecaoDependencia.GetService<ICongregacaoServico>();
            _operadoraServico = InjecaoDependencia.GetService<IOperadoraServico>();
            _publicadorServico = InjecaoDependencia.GetService<IPublicadorServico>();
            _simNaoServico = InjecaoDependencia.GetService<ISimNaoServico>();

            InitializeComponent();
        }

        private async Task CarregaDadosAsync()
        {
            try
            {
                BindHelper.SuspendBinding(CartaoBindingSource);
                BindHelper.ClearDataSource(CmbCongregacao, CongregacaoBindingSource);
                BindHelper.ClearDataSource(CmbOperadora, OperadoraBindingSource);
                BindHelper.ClearDataSource(CmbDisponivel, SimNaoBindingSource);
                BindHelper.ClearDataSource(CmbPublicador, PublicadorBindingSource);

                var congregacaoContainerDados = await _congregacaoServico.ObterAsync(informacaoPagina: _informacaoPagina, orderBy: nameof(Congregacao.Nome));
                CongregacaoBindingSource.DataSource = AutoMapeamento.Map<BindingList<Congregacao>>(congregacaoContainerDados.Dados);

                var operadoraContainerDados = await _operadoraServico.ObterAsync(informacaoPagina: _informacaoPagina, orderBy: nameof(Operadora.Nome));
                OperadoraBindingSource.DataSource = AutoMapeamento.Map<BindingList<Operadora>>(operadoraContainerDados.Dados);

                var simNaoContainerDados = await _simNaoServico.ObterAsync(informacaoPagina: _informacaoPagina, orderBy: nameof(SimNao.Id));
                SimNaoBindingSource.DataSource = AutoMapeamento.Map<BindingList<SimNao>>(simNaoContainerDados.Dados);

                var publicadorContainerDados = await _publicadorServico.ObterAsync(informacaoPagina: _informacaoPagina, orderBy: nameof(Publicador.Nome));
                PublicadorBindingSource.DataSource = AutoMapeamento.Map<BindingList<Publicador>>(publicadorContainerDados.Dados);

                CartaoBindingSource.DataSource = _cartaoFiltroDto;
            }
            finally
            {
                BindHelper.SetDataSource(CmbCongregacao, nameof(Congregacao.Id), nameof(Congregacao.Nome), CongregacaoBindingSource);
                BindHelper.SetDataSource(CmbOperadora, nameof(Operadora.Id), nameof(Operadora.Nome), OperadoraBindingSource);
                BindHelper.SetDataSource(CmbDisponivel, nameof(SimNao.Valor), nameof(SimNao.Texto), SimNaoBindingSource);
                BindHelper.SetDataSource(CmbPublicador, nameof(Publicador.Id), nameof(Publicador.Nome), PublicadorBindingSource);
                BindHelper.ResumeBinding(CartaoBindingSource);
            }
        }

        private void CartaoEditForm_Load(object sender, System.EventArgs e)
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

            mensagemErro = CustomErrorProvider.GetError(TxtNumero);
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

            if (CmbDisponivel.SelectedIndex <= 0)
                _cartaoFiltroDto.Disponivel = null;

            if (CmbDisponivel.SelectedIndex == 1)
                _cartaoFiltroDto.Disponivel = true;

            if (CmbDisponivel.SelectedIndex == 2)
                _cartaoFiltroDto.Disponivel = false;

            CartaoBindingSource.EndEdit();

            DataInicioChecked = DtpDataInicio.Checked;
            DataFimChecked = DtpDataFim.Checked;


            CartaoBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancela_Click(object sender, System.EventArgs e)
        {
            CartaoBindingSource.CancelEdit();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public bool DataInicioChecked { get; private set; }

        public bool DataFimChecked { get; private set; }

        private void BtnCmbCongregacaoLimpar_Click(object sender, System.EventArgs e)
        {
            CmbCongregacao.SelectedIndex = -1;
        }

        private void BtnCmbOperadoraLimpar_Click(object sender, System.EventArgs e)
        {
            CmbOperadora.SelectedIndex = -1;
        }

        private void BtnCmbPublicadorLimpar_Click(object sender, System.EventArgs e)
        {
            CmbPublicador.SelectedIndex = -1;
        }

        private void CartaoFiltroForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(CartaoBindingSource);
            BindHelper.SuspendBinding(CongregacaoBindingSource);
            BindHelper.SuspendBinding(OperadoraBindingSource);
            BindHelper.SuspendBinding(SimNaoBindingSource);
            BindHelper.SuspendBinding(PublicadorBindingSource);
        }
    }
}
