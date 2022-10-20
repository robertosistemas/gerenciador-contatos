using GerenciadorContatos.Aplicacao;
using GerenciadorContatos.Aplicacao.Abstracoes.Excecoes;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Aplicacao.Excecoes;
using GerenciadorContatos.Dominio;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorContatos
{
    public partial class MunicipioForm : Form
    {
        private readonly IErrorHandler _errorHandler;
        private readonly InformacaoPagina _informacaoPagina;
        private readonly InformacaoPagina _informacaoPaginaMunicipio;
        private readonly IUnidadeFederacaoServico _unidadeFederacaoServico;
        private readonly IMunicipioServico _municipioServico;

        public MunicipioForm()
        {
            _errorHandler = InjecaoDependencia.GetService<IErrorHandler>();

            _informacaoPagina = InjecaoDependencia.GetService<InformacaoPagina>();
            _informacaoPagina.Tamanho = int.MaxValue - 1;

            _informacaoPaginaMunicipio = InjecaoDependencia.GetService<InformacaoPagina>();

            _unidadeFederacaoServico = InjecaoDependencia.GetService<IUnidadeFederacaoServico>();
            _municipioServico = InjecaoDependencia.GetService<IMunicipioServico>();
            InitializeComponent();
        }

        private async Task CarregaDadosAsync(bool municipio = false, bool unidadeFederacao = false)
        {
            if (municipio)
                BindHelper.SuspendBinding(MunicipioBindingSource);
            if (unidadeFederacao)
                BindHelper.SuspendBinding(UnidadeFederacaoBindingSource);
            try
            {
                if (unidadeFederacao)
                {
                    var unidadeFederacaoContainerDados = await _unidadeFederacaoServico.ObterAsync(informacaoPagina: _informacaoPagina);
                    UnidadeFederacaoBindingSource.DataSource = AutoMapeamento.Map<BindingList<UnidadeFederacao>>(unidadeFederacaoContainerDados.Dados);
                }
                if (municipio)
                {
                    var munincipioContainerDados = await _municipioServico.ObterAsync(informacaoPagina: _informacaoPaginaMunicipio);
                    MunicipioBindingSource.DataSource = AutoMapeamento.Map<BindingList<Municipio>>(munincipioContainerDados.Dados);
                }
            }
            finally
            {
                if (unidadeFederacao)
                    BindHelper.ResumeBinding(UnidadeFederacaoBindingSource);
                if (municipio)
                    BindHelper.ResumeBinding(MunicipioBindingSource);
            }
        }

        private void MunicipioForm_Load(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, true), _errorHandler);
        }

        private void MunicipioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BindHelper.SuspendBinding(MunicipioBindingSource);
            BindHelper.SuspendBinding(UnidadeFederacaoBindingSource);
        }

        private async Task AdicionaItemAsync()
        {
            var item = new Municipio();
            using (var form = new MunicipioEditForm(item))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await CarregaDadosAsync(false, true);
                    item.Id = await _municipioServico.InserirAsync(item);
                    MunicipioBindingSource.Add(item);
                    MunicipioBindingSource.MoveLast();
                }
            }
        }

        private void BindingNavigatorAddNewItem_Click(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(AdicionaItemAsync(), _errorHandler);
        }
        private async Task ApagaItemAsync()
        {
            var item = (Municipio)MunicipioBindingSource.Current;
            if (MessageBox.Show(this, $"Confirma a exclusão do munincípio: {item.Nome}", "Gerenciador contatos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await _municipioServico.ExcluirAsync(item);
                MunicipioBindingSource.RemoveCurrent();
            }
        }
        private void BindingNavigatorDeleteItem_Click(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(ApagaItemAsync(), _errorHandler);
        }
        private async Task AlterarItemAsync()
        {
            var item = (Municipio)MunicipioBindingSource.Current;
            await CarregaDadosAsync(false, true);
            using (var form = new MunicipioEditForm(item))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MunicipioBindingSource.EndEdit();
                    item = (Municipio)MunicipioBindingSource.Current;
                    await _municipioServico.AtualizarAsync(item);
                }
                else
                {
                    MunicipioBindingSource.CancelEdit();
                }
            }
        }
        private void AlterarToolStripButton_Click(object sender, System.EventArgs e)
        {
            TaskUtilities.FireAndForgetSafeAsync(AlterarItemAsync(), _errorHandler);
        }

        private void PaginaAnteriorStripButton_Click(object sender, System.EventArgs e)
        {
            if (_informacaoPaginaMunicipio.Indice > 1)
            {
                _informacaoPaginaMunicipio.Indice--;
                TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, false), _errorHandler);
            }
        }

        private void ProximaPaginaStripButton_Click(object sender, System.EventArgs e)
        {
            if (_informacaoPaginaMunicipio.TemMaisPaginas)
            {
                _informacaoPaginaMunicipio.Indice++;
                TaskUtilities.FireAndForgetSafeAsync(CarregaDadosAsync(true, false), _errorHandler);
            }
        }
    }
}
