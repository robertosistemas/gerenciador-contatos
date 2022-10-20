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
    public partial class MunicipioEditForm : Form
    {
        private readonly IErrorHandler _errorHandler;
        private readonly InformacaoPagina _informacaoPagina;
        private readonly Municipio _municipio;
        private readonly IUnidadeFederacaoServico _unidadeFederacaoServico;
        public MunicipioEditForm()
        {
            InitializeComponent();
        }

        public MunicipioEditForm(Municipio municipio)
        {
            _municipio = municipio;
            _municipio.BeginEdit();

            _errorHandler = InjecaoDependencia.GetService<IErrorHandler>();
            _informacaoPagina = InjecaoDependencia.GetService<InformacaoPagina>();
            _unidadeFederacaoServico = InjecaoDependencia.GetService<IUnidadeFederacaoServico>();

            InitializeComponent();
        }
        private async Task CarregaDadosAsync()
        {
            try
            {
                BindHelper.SuspendBinding(MunicipioBindingSource);
                BindHelper.ClearDataSource(CmbUnidadeFederacao, UnidadeFederacaoBindingSource);

                var unidadeFederacaoContainerDados = await _unidadeFederacaoServico.ObterAsync(informacaoPagina: _informacaoPagina);
                UnidadeFederacaoBindingSource.DataSource = AutoMapeamento.Map<BindingList<UnidadeFederacao>>(unidadeFederacaoContainerDados.Dados);

                MunicipioBindingSource.DataSource = _municipio;
            }
            finally
            {
                BindHelper.SetDataSource(CmbUnidadeFederacao, nameof(UnidadeFederacao.Id), nameof(UnidadeFederacao.Nome), UnidadeFederacaoBindingSource);
                BindHelper.ResumeBinding(MunicipioBindingSource);
            }
        }

        private void MunicipioEditForm_Load(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(), _errorHandler);
        }

        private string MensagemErros()
        {
            var mensagemErros = new StringBuilder();
            var mensagemErro = CustomErrorProvider.GetError(TxtNome);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);
            mensagemErro = CustomErrorProvider.GetError(CmbUnidadeFederacao);
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
            MunicipioBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            MunicipioBindingSource.CancelEdit();
            DialogResult = DialogResult.Cancel;
            Close();
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

        private void CmbUnidadeFederacao_Validating(object sender, CancelEventArgs e)
        {
            if (CmbUnidadeFederacao.SelectedValue == null)
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(CmbUnidadeFederacao, "A escolha da unidade da federação é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(CmbUnidadeFederacao, string.Empty);
        }

        private void MunicipioEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(MunicipioBindingSource);
            BindHelper.SuspendBinding(UnidadeFederacaoBindingSource);
        }
    }
}
