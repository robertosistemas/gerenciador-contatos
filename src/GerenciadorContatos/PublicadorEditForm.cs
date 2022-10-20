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
    public partial class PublicadorEditForm : Form
    {
        private readonly IErrorHandler _errorHandler;
        private readonly InformacaoPagina _informacaoPaginaCongregacao;
        private readonly ICongregacaoServico _CongregacaoServico;
        private readonly Publicador _publicador;

        public PublicadorEditForm()
        {
            InitializeComponent();
        }

        public PublicadorEditForm(Publicador publicador)
        {
            _publicador = publicador;
            _publicador.BeginEdit();

            _errorHandler = InjecaoDependencia.GetService<IErrorHandler>();
            _informacaoPaginaCongregacao = InjecaoDependencia.GetService<InformacaoPagina>();
            _informacaoPaginaCongregacao.Tamanho = int.MaxValue - 1;
            _CongregacaoServico = InjecaoDependencia.GetService<ICongregacaoServico>();
            InitializeComponent();
        }
        private async Task CarregaDadosAsync()
        {
            try
            {
                BindHelper.SuspendBinding(PublicadorBindingSource);
                BindHelper.ClearDataSource(CmbCongregacao, CongregacaoBindingSource);

                var congregacaoContainerDados = await _CongregacaoServico.ObterAsync(informacaoPagina: _informacaoPaginaCongregacao);
                CongregacaoBindingSource.DataSource = AutoMapeamento.Map<BindingList<Congregacao>>(congregacaoContainerDados.Dados);

                PublicadorBindingSource.DataSource = _publicador;
            }
            finally
            {
                BindHelper.SetDataSource(CmbCongregacao, nameof(Congregacao.Id), nameof(Congregacao.Nome), CongregacaoBindingSource);
                BindHelper.ResumeBinding(PublicadorBindingSource);
            }
        }

        private void PublicadorEditForm_Load(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(), _errorHandler);
        }

        private string MensagemErros()
        {
            var mensagemErros = new StringBuilder();

            var mensagemErro = CustomErrorProvider.GetError(TxtNome);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);

            mensagemErro = CustomErrorProvider.GetError(CmbCongregacao);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);

            return mensagemErros.ToString();
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

        private void BtnConfirma_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show(MensagemErros(), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            PublicadorBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            PublicadorBindingSource.CancelEdit();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void PublicadorEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(PublicadorBindingSource);
            BindHelper.SuspendBinding(CongregacaoBindingSource);
        }
    }
}
