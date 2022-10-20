using GerenciadorContatos.Aplicacao;
using GerenciadorContatos.Aplicacao.Abstracoes.Excecoes;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Aplicacao.Excecoes;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Dominio.Dtos;
using LinqKit;
using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorContatos
{
    public partial class ContatoForm : Form
    {

        private readonly IErrorHandler _errorHandler;
        private readonly InformacaoPagina _informacaoPagina;
        private readonly InformacaoPagina _informacaoPaginaContato;
        private readonly IOperadoraServico _operadoraServico;
        private readonly ICartaoServico _cartaoServico;
        private readonly IContatoServico _contatoServico;
        private readonly ContatoFiltroDto _contatoFiltroDto;

        public ContatoForm(ContatoFiltroDto contatoFiltroDto)
        {
            _errorHandler = InjecaoDependencia.GetService<IErrorHandler>();

            _informacaoPagina = InjecaoDependencia.GetService<InformacaoPagina>();
            _informacaoPagina.Tamanho = int.MaxValue - 1;

            _informacaoPaginaContato = InjecaoDependencia.GetService<InformacaoPagina>();

            _operadoraServico = InjecaoDependencia.GetService<IOperadoraServico>();
            _cartaoServico = InjecaoDependencia.GetService<ICartaoServico>();
            _contatoServico = InjecaoDependencia.GetService<IContatoServico>();
            _contatoFiltroDto = contatoFiltroDto ?? new ContatoFiltroDto();

            InitializeComponent();
        }

        private async Task<Expression<Func<Contato, bool>>> ObtemFiltro()
        {
            var filtro = PredicateBuilder.New<Contato>(true);

            if (_contatoFiltroDto.OperadoraId.HasValue && _contatoFiltroDto.OperadoraId > 0)
                filtro = filtro.And(f => f.OperadoraId == _contatoFiltroDto.OperadoraId);

            if (!string.IsNullOrWhiteSpace(_contatoFiltroDto.NumeroCartao))
            {
                var cartoes = await _cartaoServico.ObterAsync(f => f.Numero == _contatoFiltroDto.NumeroCartao);
                var cartao = cartoes?.Dados?.FirstOrDefault();
                if (cartao != null)
                    filtro = filtro.And(f => f.CartaoId == cartao.Id);
            }

            if (!string.IsNullOrWhiteSpace(_contatoFiltroDto.NumeroTelefone))
                filtro = filtro.And(f => f.Numero.StartsWith(_contatoFiltroDto.NumeroTelefone));

            if (_contatoFiltroDto.PermiteLigar.HasValue)
                filtro = filtro.And(f => f.PermiteLigar == _contatoFiltroDto.PermiteLigar.Value);

            if (!string.IsNullOrWhiteSpace(_contatoFiltroDto.Nome))
                filtro = filtro.And(f => f.Nome.Contains(_contatoFiltroDto.Nome));

            return filtro;
        }

        private async Task CarregaDadosAsync(bool contato = false, bool operadora = false, bool cartao = false)
        {
            if (contato)
                BindHelper.SuspendBinding(ContatoBindingSource);
            if (operadora)
                BindHelper.SuspendBinding(OperadoraBindingSource);
            if (cartao)
                BindHelper.SuspendBinding(CartaoBindingSource);
            try
            {
                if (operadora)
                {
                    var operadoraContainerDados = await _operadoraServico.ObterAsync(informacaoPagina: _informacaoPagina);
                    OperadoraBindingSource.DataSource = AutoMapeamento.Map<BindingList<Operadora>>(operadoraContainerDados.Dados);
                }
                if (cartao)
                {
                    var cartaoContainerDados = await _cartaoServico.ObterAsync(informacaoPagina: _informacaoPagina);
                    CartaoBindingSource.DataSource = AutoMapeamento.Map<BindingList<Cartao>>(cartaoContainerDados.Dados);
                }
                if (contato)
                {
                    var contatoContainerDados = await _contatoServico.ObterAsync(filter: await ObtemFiltro(), informacaoPagina: _informacaoPaginaContato);
                    ContatoBindingSource.DataSource = AutoMapeamento.Map<BindingList<Contato>>(contatoContainerDados.Dados);
                }
            }
            finally
            {
                if (operadora)
                    BindHelper.ResumeBinding(OperadoraBindingSource);
                if (cartao)
                    BindHelper.ResumeBinding(CartaoBindingSource);
                if (contato)
                    BindHelper.ResumeBinding(ContatoBindingSource);
            }
        }

        private void ContatoForm_Load(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, true, true), _errorHandler);
        }

        private void ContatoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(ContatoBindingSource);
            BindHelper.SuspendBinding(CartaoBindingSource);
            BindHelper.SuspendBinding(OperadoraBindingSource);
        }

        private async Task AdicionaItemAsync()
        {
            var item = new Contato();
            using (var form = new ContatoEditForm(item))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await CarregaDadosAsync(false, true, true);
                    item.Id = await _contatoServico.InserirAsync(item);
                    ContatoBindingSource.Add(item);
                    ContatoBindingSource.MoveLast();
                }
            }
        }

        private void BindingNavigatorAddNewItem_Click(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(AdicionaItemAsync(), _errorHandler);
        }
        private async Task ApagaItemAsync()
        {
            var item = (Contato)ContatoBindingSource.Current;
            if (MessageBox.Show(this, $"Confirma a exclusão do contato: {item.Numero} {item.Nome}", "Gerenciador contatos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await _contatoServico.ExcluirAsync(item);
                ContatoBindingSource.RemoveCurrent();
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(ApagaItemAsync(), _errorHandler);
        }

        private async Task AlterarItemAsync()
        {
            var item = (Contato)ContatoBindingSource.Current;
            await CarregaDadosAsync(false, true, true);
            using (var form = new ContatoEditForm(item))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    ContatoBindingSource.EndEdit();
                    item = (Contato)ContatoBindingSource.Current;
                    await _contatoServico.AtualizarAsync(item);
                }
                else
                {
                    ContatoBindingSource.CancelEdit();
                }
            }
        }

        private void AlterarToolStripButton_Click(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(AlterarItemAsync(), _errorHandler);
        }

        private void PaginaAnteriorStripButton_Click(object sender, System.EventArgs e)
        {
            if (_informacaoPaginaContato.Indice > 1)
            {
                _informacaoPaginaContato.Indice--;
                TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, false, false), _errorHandler);
            }
        }

        private void ProximaPaginaStripButton_Click(object sender, System.EventArgs e)
        {
            if (_informacaoPaginaContato.TemMaisPaginas)
            {
                _informacaoPaginaContato.Indice++;
                TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, false, false), _errorHandler);
            }
        }

        private void FiltrarToolStripButton_Click(object sender, System.EventArgs e)
        {
            using (var form = new ContatoFiltroForm(_contatoFiltroDto))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    _informacaoPaginaContato.Indice = 1;
                    TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, true, true), _errorHandler);
                }
            }
        }
    }
}
