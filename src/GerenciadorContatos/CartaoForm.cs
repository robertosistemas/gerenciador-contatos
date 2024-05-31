using GerenciadorContatos.Aplicacao;
using GerenciadorContatos.Aplicacao.Abstracoes.Excecoes;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Aplicacao.Excecoes;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Dominio.Dtos;
using LinqKit;
using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorContatos
{
    public partial class CartaoForm : Form
    {

        private readonly IErrorHandler _errorHandler;
        private readonly InformacaoPagina _informacaoPagina;
        private readonly InformacaoPagina _informacaoPaginaCartao;
        private readonly ICongregacaoServico _congregacaoServico;
        private readonly IOperadoraServico _operadoraServico;
        private readonly IPublicadorServico _publicadorServico;
        private readonly ICartaoServico _cartaoServico;
        private readonly CartaoFiltroDto _cartaoFiltroDto;

        public CartaoForm(CartaoFiltroDto cartaoFiltroDto)
        {
            _errorHandler = InjecaoDependencia.GetService<IErrorHandler>();

            _informacaoPagina = InjecaoDependencia.GetService<InformacaoPagina>();
            _informacaoPagina.Tamanho = int.MaxValue - 1;

            _informacaoPaginaCartao = InjecaoDependencia.GetService<InformacaoPagina>();

            _congregacaoServico = InjecaoDependencia.GetService<ICongregacaoServico>();
            _operadoraServico = InjecaoDependencia.GetService<IOperadoraServico>();
            _publicadorServico = InjecaoDependencia.GetService<IPublicadorServico>();

            _cartaoServico = InjecaoDependencia.GetService<ICartaoServico>();

            _cartaoServico.CartoesContadosEventHandler += new CartoesContadosEventHandler(CartoesContados);
            _cartaoServico.CartaoProcessadoEventHandler += new CartaoProcessadoEventHandler(CartaoProcessado);
            _cartaoServico.CartoesExportadosEventHandler += new CartoesExportadosEventHandler(CartoesExportados);

            _cartaoFiltroDto = cartaoFiltroDto ?? new CartaoFiltroDto();

            InitializeComponent();
        }

        private Expression<Func<Cartao, bool>> ObtemFiltro()
        {
            var filtro = PredicateBuilder.New<Cartao>(true);

            if (_cartaoFiltroDto.CongregacaoId.HasValue && _cartaoFiltroDto.CongregacaoId.Value > 0)
                filtro = filtro.And(f => f.CongregacaoId == _cartaoFiltroDto.CongregacaoId);

            if (_cartaoFiltroDto.OperadoraId.HasValue && _cartaoFiltroDto.OperadoraId > 0)
                filtro = filtro.And(f => f.OperadoraId == _cartaoFiltroDto.OperadoraId);

            if (!string.IsNullOrWhiteSpace(_cartaoFiltroDto.Numero))
                filtro = filtro.And(f => f.Numero == _cartaoFiltroDto.Numero);

            if (_cartaoFiltroDto.Disponivel.HasValue)
                filtro = filtro.And(f => f.Disponivel == _cartaoFiltroDto.Disponivel.Value);

            if (_cartaoFiltroDto.PublicadorId.HasValue && _cartaoFiltroDto.PublicadorId > 0)
                filtro = filtro.And(f => f.PublicadorId == _cartaoFiltroDto.PublicadorId);

            if (_cartaoFiltroDto.DataInicio.HasValue)
                filtro = filtro.And(f => f.DataInicio >= _cartaoFiltroDto.DataInicio.Value);

            if (_cartaoFiltroDto.DataFim.HasValue)
                filtro = filtro.And(f => f.DataFim <= _cartaoFiltroDto.DataFim.Value);

            return filtro;
        }

        private async Task CarregaDadosAsync(bool cartao = false, bool publicador = false, bool operadora = false, bool congregacao = false)
        {
            if (cartao)
                BindHelper.SuspendBinding(CartaoBindingSource);
            if (publicador)
                BindHelper.SuspendBinding(PublicadorBindingSource);
            if (operadora)
                BindHelper.SuspendBinding(OperadoraBindingSource);
            if (congregacao)
                BindHelper.SuspendBinding(CongregacaoBindingSource);
            try
            {
                if (congregacao)
                {
                    var congregacaoContainerDados = await _congregacaoServico.ObterAsync(informacaoPagina: _informacaoPagina);
                    CongregacaoBindingSource.DataSource = AutoMapeamento.Map<BindingList<Congregacao>>(congregacaoContainerDados.Dados);
                }
                if (operadora)
                {
                    var operadoraContainerDados = await _operadoraServico.ObterAsync(informacaoPagina: _informacaoPagina);
                    OperadoraBindingSource.DataSource = AutoMapeamento.Map<BindingList<Operadora>>(operadoraContainerDados.Dados);
                }
                if (publicador)
                {
                    var publicadorContainerDados = await _publicadorServico.ObterAsync(informacaoPagina: _informacaoPagina);
                    PublicadorBindingSource.DataSource = AutoMapeamento.Map<BindingList<Publicador>>(publicadorContainerDados.Dados);
                }
                if (cartao)
                {
                    var cartaoContainerDados = await _cartaoServico.ObterAsync(filter: ObtemFiltro(), informacaoPagina: _informacaoPaginaCartao);
                    CartaoBindingSource.DataSource = AutoMapeamento.Map<BindingList<Cartao>>(cartaoContainerDados.Dados);
                }
            }
            finally
            {
                if (publicador)
                    BindHelper.ResumeBinding(PublicadorBindingSource);
                if (operadora)
                    BindHelper.ResumeBinding(OperadoraBindingSource);
                if (congregacao)
                    BindHelper.ResumeBinding(CongregacaoBindingSource);
                if (cartao)
                    BindHelper.ResumeBinding(CartaoBindingSource);
            }
        }

        private async void CartaoForm_Load(object sender, System.EventArgs e)
        {
            await CarregaDadosAsync(true, true, true, true);
        }

        private void CartaoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(CartaoBindingSource);
            BindHelper.SuspendBinding(PublicadorBindingSource);
            BindHelper.SuspendBinding(OperadoraBindingSource);
            BindHelper.SuspendBinding(CongregacaoBindingSource);
        }

        private async Task AdicionaItemAsync()
        {
            var item = new Cartao();
            using (var form = new CartaoEditForm(item, CartaoModoExibicaoEnum.Inclusao))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {

                    if (!form.DataInicioChecked)
                        item.DataInicio = null;

                    if (!form.DataFimChecked)
                        item.DataFim = null;

                    await CarregaDadosAsync(false, true, true, true);
                    item.Id = await _cartaoServico.InserirAsync(item);

                    CartaoBindingSource.Add(item);
                    CartaoBindingSource.MoveLast();
                }
            }
        }

        private void BindingNavigatorAddNewItem_Click(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(AdicionaItemAsync(), _errorHandler);
        }

        private async Task ApagaItemAsync()
        {
            var item = (Cartao)CartaoBindingSource.Current;
            if (MessageBox.Show(this, $"Confirma a exclusão do cartão: {item.Numero}", "Gerenciador contatos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await _cartaoServico.ExcluirAsync(item);
                CartaoBindingSource.RemoveCurrent();
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(ApagaItemAsync(), _errorHandler);
        }
        private async Task AlterarItemAsync()
        {
            var item = (Cartao)CartaoBindingSource.Current;
            await CarregaDadosAsync(false, true, true, true);
            using (var form = new CartaoEditForm(item, CartaoModoExibicaoEnum.Alteracao))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    if (!form.DataInicioChecked)
                        item.DataInicio = null;

                    if (!form.DataFimChecked)
                        item.DataFim = null;

                    CartaoBindingSource.EndEdit();
                    item = (Cartao)CartaoBindingSource.Current;
                    await _cartaoServico.AtualizarAsync(item);
                }
                else
                {
                    CartaoBindingSource.CancelEdit();
                }
            }
        }

        private void AlterarToolStripButton_Click(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(AlterarItemAsync(), _errorHandler);
        }

        private void PaginaAnteriorStripButton_Click(object sender, System.EventArgs e)
        {
            if (_informacaoPaginaCartao.Indice > 1)
            {
                _informacaoPaginaCartao.Indice--;
                TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true), _errorHandler);
            }
        }

        private void ProximaPaginaStripButton_Click(object sender, System.EventArgs e)
        {
            if (_informacaoPaginaCartao.TemMaisPaginas)
            {
                _informacaoPaginaCartao.Indice++;
                TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true), _errorHandler);
            }
        }

        private void CartaoDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (CartaoBindingSource.Count > 0 && CartaoBindingSource.Position >= 0)
                {
                    CartaoDataGridViewContextMenuStrip.Show(CartaoDataGridView, e.Location);
                }
            }
        }

        private void FiltrarToolStripButton_Click(object sender, System.EventArgs e)
        {
            using (var form = new CartaoFiltroForm(_cartaoFiltroDto))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    if (!form.DataInicioChecked)
                        _cartaoFiltroDto.DataInicio = null;

                    if (!form.DataFimChecked)
                        _cartaoFiltroDto.DataFim = null;

                    _informacaoPaginaCartao.Indice = 1;
                    TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, true, true, true), _errorHandler);
                }
            }
        }

        private async Task GerarCartaoMemoriaAsync(bool comFormatacao, bool colocarTracos)
        {
            var item = (Cartao)CartaoBindingSource.Current;
            if (item != null)
            {
                var cartaEmMemoria = await _cartaoServico.GerarDadosCartaoAsync(item, comFormatacao, colocarTracos);
                Clipboard.SetText(cartaEmMemoria.ToString());
                MessageBox.Show("Dados do cartão gerado em memória com sucesso!", "Gerenciador contatos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GerarCartaoEmMemoriaSemTracosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(GerarCartaoMemoriaAsync(true, false), _errorHandler);
        }

        private void GerarCartaoEmMemoriaComTracosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(GerarCartaoMemoriaAsync(true, true), _errorHandler);
        }

        private void GerarCartaoEmMemoriaSemFormatacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(GerarCartaoMemoriaAsync(false, false), _errorHandler);
        }

        private async Task DesignarAsync()
        {
            var item = (Cartao)CartaoBindingSource.Current;
            if (item.PublicadorId.HasValue && !item.Disponivel)
            {
                MessageBox.Show("Este cartão já foi designado e ainda não foi devolvido!", "Gerenciador contatos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            await CarregaDadosAsync(false, true, true, true);
            using (var form = new CartaoEditForm(item, CartaoModoExibicaoEnum.Designacao))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    if (!form.DataInicioChecked)
                        item.DataInicio = null;

                    if (!form.DataFimChecked)
                        item.DataFim = null;
                    CartaoBindingSource.EndEdit();
                    item = (Cartao)CartaoBindingSource.Current;
                    await _cartaoServico.DesignarAsync(item);
                    var cartaEmMemoria = await _cartaoServico.GerarDadosCartaoAsync(item, false, false);
                    Clipboard.SetText(cartaEmMemoria.ToString());
                    MessageBox.Show("O cartão foi designado com sucesso!\nDados do cartão também foram colocados em memória.", "Gerenciador contatos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CartaoBindingSource.CancelEdit();
                }
            }
        }

        private void DesignarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(DesignarAsync(), _errorHandler);
        }

        private async Task DevolverAsync()
        {
            var item = (Cartao)CartaoBindingSource.Current;

            if (item.Disponivel || !item.PublicadorId.HasValue)
            {
                MessageBox.Show("Este cartão não pode ser devolvido pois ainda não foi designado!", "Gerenciador contatos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (item.Disponivel && item.PublicadorId.HasValue && item.DataFim.HasValue)
            {
                MessageBox.Show("Este cartão já foi devolvido!", "Gerenciador contatos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            await CarregaDadosAsync(false, true, true, true);
            using (var form = new CartaoEditForm(item, CartaoModoExibicaoEnum.Devolucao))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    if (!form.DataInicioChecked)
                        item.DataInicio = null;

                    if (!form.DataFimChecked)
                        item.DataFim = null;

                    CartaoBindingSource.EndEdit();
                    item = (Cartao)CartaoBindingSource.Current;
                    await _cartaoServico.DevolverAsync(item);
                    MessageBox.Show("O cartão foi devolvido com sucesso!", "Gerenciador contatos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CartaoBindingSource.CancelEdit();
                }
            }
        }

        private void DevolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(DevolverAsync(), _errorHandler);
        }

        private void MostrarContatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (Cartao)CartaoBindingSource.Current;
            if (item != null)
            {
                var contatoFiltroDto = new ContatoFiltroDto { NumeroCartao = item.Numero };
                using (var contatoForm = new ContatoForm(contatoFiltroDto))
                {
                    contatoForm.StartPosition = FormStartPosition.CenterScreen;
                    contatoForm.ShowDialog(this);
                }
            }
        }

        private void ExportarToolStripButton_Click(object sender, EventArgs e)
        {
            if (ExportarSaveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                TaskUtilities.FireAndForgetSafeAsync(_cartaoServico.ExportarCartoesAsync(ObtemFiltro(), nameof(Cartao.Id), ExportarSaveFileDialog.FileName), _errorHandler);
            }
        }

        private void CartoesContados(object sender, CartaoEventArgs cartaoEventArgs)
        {
            CartoesProgressBar.Minimum = 1;
            CartoesProgressBar.Maximum = cartaoEventArgs.Quantidade;
            CartoesProgressBar.Value = 1;
            CartoesProgressBar.Visible = true;
        }

        private void CartaoProcessado(object sender, CartaoEventArgs cartaoEventArgs)
        {
            CartoesProgressBar.Value = cartaoEventArgs.ItemAtual;
        }

        private void CartoesExportados(object sender, CartaoEventArgs cartaoEventArgs)
        {
            MessageBox.Show($"Foram exportados {cartaoEventArgs.Quantidade} cartões com sucesso!", "Gerenciador contatos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CartoesProgressBar.Visible = false;
        }

        private void DesignarToolStripButton_Click(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(DesignarAsync(), _errorHandler);
        }

        private void DevolverToolStripButton_Click(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(DevolverAsync(), _errorHandler);
        }
    }
}
