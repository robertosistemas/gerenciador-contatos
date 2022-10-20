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
    public enum CartaoModoExibicaoEnum
    {
        Inclusao,
        Alteracao,
        Exclucao,
        Consulta,
        Designacao,
        Devolucao
    }

    public partial class CartaoEditForm : Form
    {

        private readonly Cartao _cartao;
        private readonly CartaoModoExibicaoEnum _cartaoModoExibicaoEnum;
        private readonly IErrorHandler _errorHandler;
        private readonly InformacaoPagina _informacaoPagina;
        private readonly ICongregacaoServico _congregacaoServico;
        private readonly IOperadoraServico _operadoraServico;
        private readonly IPublicadorServico _publicadorServico;

        public CartaoEditForm()
        {
            InitializeComponent();
        }

        public CartaoEditForm(Cartao cartao, CartaoModoExibicaoEnum cartaoModoExibicaoEnum)
        {
            _cartao = cartao;
            _cartao.BeginEdit();

            _cartaoModoExibicaoEnum = cartaoModoExibicaoEnum;
            _errorHandler = InjecaoDependencia.GetService<IErrorHandler>();

            _informacaoPagina = InjecaoDependencia.GetService<InformacaoPagina>();
            _informacaoPagina.Tamanho = int.MaxValue - 1;

            _congregacaoServico = InjecaoDependencia.GetService<ICongregacaoServico>();
            _operadoraServico = InjecaoDependencia.GetService<IOperadoraServico>();
            _publicadorServico = InjecaoDependencia.GetService<IPublicadorServico>();

            InitializeComponent();

            if (_cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Inclusao)
            {
                _cartao.PublicadorId = null;
                _cartao.Disponivel = true;
                _cartao.DataInicio = null;
                _cartao.DataFim = null;
            }

            if (_cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Designacao)
            {
                _cartao.PublicadorId = null;
                _cartao.Disponivel = false;
                _cartao.DataInicio = DateTime.Now;
                _cartao.DataFim = null;
            }

            if (_cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Devolucao)
            {
                _cartao.Disponivel = true;
                _cartao.DataFim = DateTime.Now;
            }

        }

        private void ConfiguraCampos()
        {
            if (_cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Inclusao
                || _cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Alteracao)
            {
                CmbCongregacao.Enabled = true;
                CmbOperadora.Enabled = true;
                TxtNumero.Enabled = true;
                TxtFaixaNumerica.Enabled = true;

                ChkDisponivel.Enabled = false;
                ChkDisponivel.Checked = true;

                CmbPublicador.Enabled = false;
                DtpDataInicio.Enabled = false;
                DtpDataFim.Enabled = false;
                TxtObservacao.Enabled = true;
            }

            if (_cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Designacao
                || _cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Devolucao)
            {
                CmbCongregacao.Enabled = false;
                CmbOperadora.Enabled = false;
                TxtNumero.Enabled = false;
                TxtFaixaNumerica.Enabled = false;
                ChkDisponivel.Enabled = false;

                CmbPublicador.Enabled = _cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Designacao;

                DtpDataInicio.Enabled = false;
                DtpDataFim.Enabled = true;
                TxtObservacao.Enabled = true;

            }
        }

        private async Task CarregaDadosAsync()
        {
            try
            {
                BindHelper.SuspendBinding(CartaoBindingSource);
                BindHelper.ClearDataSource(CmbCongregacao, CongregacaoBindingSource);
                BindHelper.ClearDataSource(CmbOperadora, OperadoraBindingSource);
                BindHelper.ClearDataSource(CmbPublicador, PublicadorBindingSource);

                var congregacaoContainerDados = await _congregacaoServico.ObterAsync(informacaoPagina: _informacaoPagina, orderBy: nameof(Congregacao.Nome));
                CongregacaoBindingSource.DataSource = AutoMapeamento.Map<BindingList<Congregacao>>(congregacaoContainerDados.Dados);

                var operadoraContainerDados = await _operadoraServico.ObterAsync(informacaoPagina: _informacaoPagina, orderBy: nameof(Operadora.Nome));
                OperadoraBindingSource.DataSource = AutoMapeamento.Map<BindingList<Operadora>>(operadoraContainerDados.Dados);

                var publicadorContainerDados = await _publicadorServico.ObterAsync(informacaoPagina: _informacaoPagina, orderBy: nameof(Operadora.Nome));
                PublicadorBindingSource.DataSource = AutoMapeamento.Map<BindingList<Publicador>>(publicadorContainerDados.Dados);

                CartaoBindingSource.DataSource = _cartao;
            }
            finally
            {
                BindHelper.SetDataSource(CmbCongregacao, nameof(Congregacao.Id), nameof(Congregacao.Nome), CongregacaoBindingSource);
                BindHelper.SetDataSource(CmbOperadora, nameof(Operadora.Id), nameof(Operadora.Nome), OperadoraBindingSource);
                BindHelper.SetDataSource(CmbPublicador, nameof(Publicador.Id), nameof(Publicador.Nome), PublicadorBindingSource);
                BindHelper.ResumeBinding(CartaoBindingSource);
            }
        }

        private void CartaoEditForm_Load(object sender, System.EventArgs e)
        {
            ConfiguraCampos();
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

            mensagemErro = CustomErrorProvider.GetError(TxtFaixaNumerica);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);

            mensagemErro = CustomErrorProvider.GetError(ChkDisponivel);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);

            mensagemErro = CustomErrorProvider.GetError(CmbPublicador);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);

            mensagemErro = CustomErrorProvider.GetError(DtpDataInicio);
            if (!string.IsNullOrWhiteSpace(mensagemErro))
                mensagemErros.AppendLine(mensagemErro);

            mensagemErro = CustomErrorProvider.GetError(DtpDataFim);
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
            CartaoBindingSource.EndEdit();

            DataInicioChecked = DtpDataInicio.Checked;
            DataFimChecked = DtpDataFim.Checked;

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

        private void TxtNumero_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNumero.Text))
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(TxtNumero, "A digitação do número é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(TxtNumero, string.Empty);
        }

        private void TxtFaixaNumerica_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtFaixaNumerica.Text))
            {
                e.Cancel = true;
                CustomErrorProvider.SetError(TxtFaixaNumerica, "A digitação da faixa numérica é obrigatório!");
            }
            else
                CustomErrorProvider.SetError(TxtFaixaNumerica, string.Empty);
        }

        private void ChkDisponivel_Validating(object sender, CancelEventArgs e)
        {
            if (_cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Inclusao)
            {
                if (!ChkDisponivel.Checked)
                {
                    e.Cancel = true;
                    CustomErrorProvider.SetError(ChkDisponivel, "O cartão tem que ficar disponível quando for incluído!");
                }
                else
                    CustomErrorProvider.SetError(ChkDisponivel, string.Empty);
            }

            if (_cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Designacao)
            {
                if (ChkDisponivel.Checked)
                {
                    e.Cancel = true;
                    CustomErrorProvider.SetError(ChkDisponivel, "O cartão não pode estar disponível quando for designado!");
                }
                else
                    CustomErrorProvider.SetError(ChkDisponivel, string.Empty);
            }

            if (_cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Devolucao)
            {
                if (!ChkDisponivel.Checked)
                {
                    e.Cancel = true;
                    CustomErrorProvider.SetError(ChkDisponivel, "O cartão tem que ficar disponível quando for devolvido!");
                }
                else
                    CustomErrorProvider.SetError(ChkDisponivel, string.Empty);
            }
        }

        private void CmbPublicador_Validating(object sender, CancelEventArgs e)
        {
            if (_cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Designacao
                || _cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Devolucao)
            {
                if (CmbPublicador.SelectedValue == null)
                {
                    e.Cancel = true;
                    CustomErrorProvider.SetError(CmbPublicador, "A escolha da publicador é obrigatório!");
                }
                else
                    CustomErrorProvider.SetError(CmbPublicador, string.Empty);
            }
        }

        private void DtpDataInicio_Validating(object sender, CancelEventArgs e)
        {
            if (_cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Designacao
                || _cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Devolucao)
            {
                if (!DtpDataInicio.Checked || DtpDataInicio.Value == null)
                {
                    e.Cancel = true;
                    CustomErrorProvider.SetError(DtpDataInicio, "É necessário informar uma data de início!");
                }
                else
                    CustomErrorProvider.SetError(DtpDataInicio, string.Empty);
            }
        }

        private void DtpDataFim_Validating(object sender, CancelEventArgs e)
        {
            if (_cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Inclusao)
            {
                if (DtpDataFim.Checked || DtpDataFim.Value != null)
                {
                    e.Cancel = true;
                    CustomErrorProvider.SetError(DtpDataFim, "Não é permitido informar uma data final na inclusão!");
                }
                else
                    CustomErrorProvider.SetError(DtpDataFim, string.Empty);
            }

            if (_cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Designacao)
            {
                if (DtpDataFim.Checked || DtpDataFim.Value != null)
                {
                    e.Cancel = true;
                    CustomErrorProvider.SetError(DtpDataFim, "Não é permitido informar uma data final na designação!");
                }
                else
                    CustomErrorProvider.SetError(DtpDataFim, string.Empty);
            }

            if (_cartaoModoExibicaoEnum == CartaoModoExibicaoEnum.Devolucao)
            {
                if (!DtpDataFim.Checked || DtpDataFim.Value == null)
                {
                    e.Cancel = true;
                    CustomErrorProvider.SetError(DtpDataFim, "É necessário informar uma data final para devolução!");
                }
                else
                    CustomErrorProvider.SetError(DtpDataFim, string.Empty);
            }

        }

        private void CartaoEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(CartaoBindingSource);
            BindHelper.SuspendBinding(CongregacaoBindingSource);
            BindHelper.SuspendBinding(OperadoraBindingSource);
            BindHelper.SuspendBinding(PublicadorBindingSource);
        }
    }
}
