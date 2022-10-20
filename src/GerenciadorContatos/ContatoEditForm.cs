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
    public partial class ContatoEditForm : Form
    {
        private readonly IErrorHandler _errorHandler;
        private readonly InformacaoPagina _informacaoPagina;
        private readonly IOperadoraServico _operadoraServico;
        private readonly ICartaoServico _cartaoServico;
        private readonly Contato _contato;

        public ContatoEditForm()
        {
            InitializeComponent();
        }

        public ContatoEditForm(Contato contato)
        {
            _contato = contato;
            _contato.BeginEdit();

            _errorHandler = InjecaoDependencia.GetService<IErrorHandler>();

            _informacaoPagina = InjecaoDependencia.GetService<InformacaoPagina>();
            _informacaoPagina.Tamanho = int.MaxValue - 1;

            _operadoraServico = InjecaoDependencia.GetService<IOperadoraServico>();
            _cartaoServico = InjecaoDependencia.GetService<ICartaoServico>();

            InitializeComponent();
        }
        private async Task CarregaDadosAsync()
        {
            try
            {
                BindHelper.SuspendBinding(ContatoBindingSource);
                BindHelper.ClearDataSource(CmbOperadora, OperadoraBindingSource);
                BindHelper.ClearDataSource(CmbCartao, CartaoBindingSource);

                var operadoraContainerDados = await _operadoraServico.ObterAsync(informacaoPagina: _informacaoPagina, orderBy: nameof(Operadora.Nome));
                OperadoraBindingSource.DataSource = AutoMapeamento.Map<BindingList<Operadora>>(operadoraContainerDados.Dados);

                var cartaoContainerDados = await _cartaoServico.ObterAsync(informacaoPagina: _informacaoPagina, orderBy: nameof(Cartao.Id));
                CartaoBindingSource.DataSource = AutoMapeamento.Map<BindingList<Cartao>>(cartaoContainerDados.Dados);

                ContatoBindingSource.DataSource = _contato;
            }
            finally
            {
                BindHelper.SetDataSource(CmbOperadora, nameof(Operadora.Id), nameof(Operadora.Nome), OperadoraBindingSource);
                BindHelper.SetDataSource(CmbCartao, nameof(Publicador.Id), nameof(Publicador.Nome), CartaoBindingSource);
                BindHelper.ResumeBinding(ContatoBindingSource);
            }
        }

        private void ContatoEditForm_Load(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(), _errorHandler);
        }

        private void CmbOperadora_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (CmbOperadora.SelectedValue == null)
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(CmbOperadora, "A escolha da operadora é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(CmbOperadora, string.Empty);
        }

        private void CmbCartao_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (CmbCartao.SelectedValue == null)
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(CmbCartao, "A escolha do cartão é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(CmbCartao, string.Empty);
        }

        private void TxtNumero_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNumero.Text))
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(TxtNumero, "A digitação do número é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(TxtNumero, string.Empty);
        }

        private string MensagemErros()
        {
            var mensagemErros = new StringBuilder();

            var mensagemErro = CustomErrorProvider.GetError(CmbOperadora);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);

            mensagemErro = CustomErrorProvider.GetError(CmbCartao);
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

        private void ContatoEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(ContatoBindingSource);
            BindHelper.SuspendBinding(OperadoraBindingSource);
            BindHelper.SuspendBinding(CartaoBindingSource);
        }
    }
}
