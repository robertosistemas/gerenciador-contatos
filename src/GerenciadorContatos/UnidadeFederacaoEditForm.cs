using GerenciadorContatos.Dominio;
using System;
using System.Text;
using System.Windows.Forms;

namespace GerenciadorContatos
{
    public partial class UnidadeFederacaoEditForm : Form
    {
        private readonly UnidadeFederacao _unidadeFederacao;

        public UnidadeFederacaoEditForm()
        {
            InitializeComponent();
        }
        public UnidadeFederacaoEditForm(UnidadeFederacao unidadeFederacao)
        {
            InitializeComponent();
            _unidadeFederacao = unidadeFederacao;
            _unidadeFederacao.BeginEdit();
        }

        private void CarregaDadosAsync()
        {
            BindHelper.SuspendBinding(UnidadeFederacaoBindingSource);
            UnidadeFederacaoBindingSource.DataSource = _unidadeFederacao;
            BindHelper.ResumeBinding(UnidadeFederacaoBindingSource);
        }

        private void UnidadeFederacaoEditForm_Load(object sender, EventArgs e)
        {
            CarregaDadosAsync();
        }

        private string MensagemErros()
        {
            var mensagemErros = new StringBuilder();
            var mensagemErro = CustomErrorProvider.GetError(TxtSigla);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);
            mensagemErro = CustomErrorProvider.GetError(TxtNome);
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
            _unidadeFederacao.EndEdit();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            _unidadeFederacao.CancelEdit();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TxtSigla_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSigla.Text))
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(TxtSigla, "A digitação da sigla é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(TxtSigla, string.Empty);
        }

        private void TxtNome_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(TxtNome, "A digitação do nome é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(TxtNome, string.Empty);
        }

        private void UnidadeFederacaoEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(UnidadeFederacaoBindingSource);
        }
    }
}
