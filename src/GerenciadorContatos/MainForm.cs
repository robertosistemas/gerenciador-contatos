using System;
using System.Windows.Forms;

namespace GerenciadorContatos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sobreForm = new SobreForm())
            {
                sobreForm.ShowDialog(this);
            }
        }

        private void UnidadeFederacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var unidadeFederacaoForm = new UnidadeFederacaoForm
            {
                MdiParent = this
            };
            unidadeFederacaoForm.Show();
        }

        private void MunicipiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var municipioForm = new MunicipioForm
            {
                MdiParent = this
            };
            municipioForm.Show();
        }

        private void CongregacoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var congregacaoForm = new CongregacaoForm
            {
                MdiParent = this
            };
            congregacaoForm.Show();
        }

        private void PublicadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var publicadorForm = new PublicadorForm
            {
                MdiParent = this
            };
            publicadorForm.Show();
        }

        private void OperadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var operadoraForm = new OperadoraForm
            {
                MdiParent = this
            };
            operadoraForm.Show();
        }

        private void CartoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cartaoForm = new CartaoForm(null)
            {
                MdiParent = this
            };
            cartaoForm.Show();
        }

        private void ContatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var contatoForm = new ContatoForm(null)
            {
                MdiParent = this
            };
            contatoForm.Show();
        }

        private void SequenciasNumericasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sequenciaForm = new SequenciaNumericaForm
            {
                MdiParent = this
            };
            sequenciaForm.Show();
        }
    }
}
