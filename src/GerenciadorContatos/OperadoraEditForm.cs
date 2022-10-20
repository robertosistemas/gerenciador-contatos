using GerenciadorContatos.Dominio;
using System;
using System.Text;
using System.Windows.Forms;

namespace GerenciadorContatos
{
    public partial class OperadoraEditForm : Form
    {
        private readonly Operadora _operadora;

        public OperadoraEditForm()
        {
            InitializeComponent();
        }

        public OperadoraEditForm(Operadora operadora)
        {
            _operadora = operadora;
            _operadora.BeginEdit();

            InitializeComponent();
        }
        private void CarregaDados()
        {
            BindHelper.SuspendBinding(OperadoraBindingSource);
            OperadoraBindingSource.DataSource = _operadora;
            BindHelper.ResumeBinding(OperadoraBindingSource);
        }

        private void OperadoraEditForm_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private string MensagemErros()
        {
            var mensagemErros = new StringBuilder();
            var mensagemErro = CustomErrorProvider.GetError(TxtCodigo);
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
            OperadoraBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            OperadoraBindingSource.CancelEdit();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TxtCodigo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(TxtCodigo.Text, out int codigo) || codigo <= 0)
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(TxtCodigo, "A digitação do código é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(TxtCodigo, string.Empty);
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

        private void OperadoraEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(OperadoraBindingSource);
        }
    }
}
