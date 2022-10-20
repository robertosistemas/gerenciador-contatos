using GerenciadorContatos.Aplicacao;
using GerenciadorContatos.Aplicacao.Abstracoes.Excecoes;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Aplicacao.Excecoes;
using GerenciadorContatos.Dominio;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorContatos
{
    public partial class OperadoraForm : Form
    {
        private readonly IErrorHandler _errorHandler;
        private readonly InformacaoPagina _informacaoPagina;
        private readonly IOperadoraServico _operadoraServico;

        public OperadoraForm()
        {
            _errorHandler = InjecaoDependencia.GetService<IErrorHandler>();
            _informacaoPagina = InjecaoDependencia.GetService<InformacaoPagina>();
            _operadoraServico = InjecaoDependencia.GetService<IOperadoraServico>();
            InitializeComponent();
        }

        private async Task CarregaDadosAsync()
        {
            BindHelper.SuspendBinding(OperadoraBindingSource);
            try
            {
                var containerDados = await _operadoraServico.ObterAsync(informacaoPagina: _informacaoPagina);
                OperadoraBindingSource.DataSource = AutoMapeamento.Map<BindingList<Operadora>>(containerDados.Dados);
            }
            finally
            {
                BindHelper.ResumeBinding(OperadoraBindingSource);
            }
        }

        private void OperadoraForm_Load(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(), _errorHandler);
        }

        private void OperadoraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(OperadoraBindingSource);
        }

        private async Task AdicionaItemAsync()
        {
            var item = new Operadora();
            using (var form = new OperadoraEditForm(item))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    item.Id = await _operadoraServico.InserirAsync(item);
                    OperadoraBindingSource.Add(item);
                    OperadoraBindingSource.MoveLast();
                }
            }
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(AdicionaItemAsync(), _errorHandler);
        }

        private void OperadoraBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate
                            && e.Exception == null)
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }

        private async Task AlterarItemAsync()
        {
            var item = (Operadora)OperadoraBindingSource.Current;
            using (var form = new OperadoraEditForm(item))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    OperadoraBindingSource.EndEdit();
                    item = (Operadora)OperadoraBindingSource.Current;
                    await _operadoraServico.AtualizarAsync(item);
                }
                else
                {
                    OperadoraBindingSource.CancelEdit();
                }
            }
        }

        private void AlterarToolStripButton_Click(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(AlterarItemAsync(), _errorHandler);
        }

        private async Task ApagaItemAsync()
        {
            var item = (Operadora)OperadoraBindingSource.Current;
            if (MessageBox.Show(this, $"Confirma a exclusão da operadora: {item.Nome}", "Gerenciador contatos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await _operadoraServico.ExcluirAsync(item);
                OperadoraBindingSource.RemoveCurrent();
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(ApagaItemAsync(), _errorHandler);
        }

        private void PaginaAnteriorStripButton_Click(object sender, EventArgs e)
        {
            if (_informacaoPagina.Indice > 1)
            {
                _informacaoPagina.Indice--;
                TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(), _errorHandler);
            }
        }

        private void ProximaPaginaStripButton_Click(object sender, EventArgs e)
        {
            if (_informacaoPagina.TemMaisPaginas)
            {
                _informacaoPagina.Indice++;
                TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(), _errorHandler);
            }
        }
    }
}
