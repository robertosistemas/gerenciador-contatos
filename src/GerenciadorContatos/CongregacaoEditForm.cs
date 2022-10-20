using GerenciadorContatos.Aplicacao;
using GerenciadorContatos.Aplicacao.Abstracoes.Excecoes;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Aplicacao.Excecoes;
using GerenciadorContatos.Dominio;
using System;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorContatos
{
    public partial class CongregacaoEditForm : Form
    {
        private readonly IErrorHandler _errorHandler;
        private readonly InformacaoPagina _informacaoPagina;
        private readonly Congregacao _congregacao;
        private readonly IMunicipioServico _municipioServico;
        public CongregacaoEditForm()
        {
            InitializeComponent();
        }

        public CongregacaoEditForm(Congregacao congregacao)
        {
            _congregacao = congregacao;
            _congregacao.BeginEdit();

            _errorHandler = InjecaoDependencia.GetService<IErrorHandler>();
            _informacaoPagina = InjecaoDependencia.GetService<InformacaoPagina>();
            _municipioServico = InjecaoDependencia.GetService<IMunicipioServico>();
            InitializeComponent();
        }

        private async Task CarregaDadosAsync()
        {
            try
            {
                BindHelper.SuspendBinding(CongregacaoBindingSource);
                BindHelper.ClearDataSource(CmbMunicipio, MunincipioBindingSource);

                var containerDados = await _municipioServico.ObterAsync(informacaoPagina: _informacaoPagina);
                MunincipioBindingSource.DataSource = AutoMapeamento.Map<BindingList<Municipio>>(containerDados.Dados);

                CongregacaoBindingSource.DataSource = _congregacao;
            }
            finally
            {
                BindHelper.SetDataSource(CmbMunicipio, nameof(Municipio.Id), nameof(Municipio.Nome), MunincipioBindingSource);
                BindHelper.ResumeBinding(CongregacaoBindingSource);
            }
        }

        private void CongregacaoEditForm_Load(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(), _errorHandler);
        }
        private string MensagemErros()
        {
            var mensagemErros = new StringBuilder();
            var mensagemErro = CustomErrorProvider.GetError(TxtNumero);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);
            mensagemErro = CustomErrorProvider.GetError(TxtNome);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);
            mensagemErro = CustomErrorProvider.GetError(CmbMunicipio);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);
            return mensagemErros.ToString();
        }

        private void BtnConfirma_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show(MensagemErros(), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            CongregacaoBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            CongregacaoBindingSource.CancelEdit();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TxtNumero_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(TxtNumero.Text, out int codigo) || codigo <= 0)
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(TxtNumero, "A digitação do número é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(TxtNumero, string.Empty);
        }

        private void TxtNome_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(TxtNome, "A digitação do nome é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(TxtNome, string.Empty);
        }

        private void CmbMunicipio_Validating(object sender, CancelEventArgs e)
        {
            if (CmbMunicipio.SelectedValue == null)
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(CmbMunicipio, "A escolha da cidade é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(CmbMunicipio, string.Empty);
        }

        private void CongregacaoEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(CongregacaoBindingSource);
            BindHelper.SuspendBinding(MunincipioBindingSource);
        }
    }
}
