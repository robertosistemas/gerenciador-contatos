using GerenciadorContatos.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace GerenciadorContatos.Tests.Aplicacao.Servicos
{
    [TestClass]
    public class MunicipioServicoUnitTest : DatabaseTesteBase
    {
        private UnidadeFederacao _unidadeFederacao;

        [TestInitialize]
        public async Task SetUp()
        {
            if (_unidadeFederacao == null)
            {
                _unidadeFederacao = await CriarUnidadeFederacaoAsync();
            }
        }

        [TestMethod]
        public async Task Quando_Inserir_Um_Registro_Devera_Criar_Registro_Async()
        {
            var id = await MunicipioServico.InserirAsync(new Municipio { UnidadeFederacaoId = _unidadeFederacao.Id, Nome = $"Cidade-{System.Guid.NewGuid()}" });
            var municipio = await MunicipioServico.ObterPorIdAsync(id);
            Assert.AreEqual(id, municipio.Id);
        }

        [TestMethod]
        public async Task Quando_Inserir_Varios_Registros_Devera_Criar_Registros_Async()
        {
            var nomes = new List<string>();
            var municipios = new List<Municipio>();

            var nome = $"Florianópolis-{System.Guid.NewGuid()}";
            municipios.Add(new Municipio { UnidadeFederacaoId = _unidadeFederacao.Id, Nome = nome });
            nomes.Add(nome);

            nome = $"Palhoça-{System.Guid.NewGuid()}";
            municipios.Add(new Municipio { UnidadeFederacaoId = _unidadeFederacao.Id, Nome = nome });
            nomes.Add(nome);

            nome = $"Bigaçu-{System.Guid.NewGuid()}";
            municipios.Add(new Municipio { UnidadeFederacaoId = _unidadeFederacao.Id, Nome = nome });
            nomes.Add(nome);

            nome = $"São José-{System.Guid.NewGuid()}";
            municipios.Add(new Municipio { UnidadeFederacaoId = _unidadeFederacao.Id, Nome = nome });
            nomes.Add(nome);

            await MunicipioServico.InserirAsync(municipios);

            var municipiosConsultadas = await MunicipioServico.ObterAsync(f => nomes.Any(item => item == f.Nome));

            Assert.AreEqual(4, municipiosConsultadas.Dados.Count);
        }

        [TestMethod]
        public async Task Quando_Alterar_Devera_Modificar_Registro_Async()
        {
            var primeiroNome = $"Floripa-{System.Guid.NewGuid()}";
            var segundoNome = $"Florianópolis-{System.Guid.NewGuid()}";
            var municipio = new Municipio { UnidadeFederacaoId = _unidadeFederacao.Id, Nome = primeiroNome };
            var id = await MunicipioServico.InserirAsync(municipio);
            var municipioConsultada = await MunicipioServico.ObterPorIdAsync(id);
            Assert.AreEqual(primeiroNome, municipioConsultada.Nome);
            municipioConsultada.Nome = segundoNome;
            await MunicipioServico.AtualizarAsync(municipioConsultada);
            municipioConsultada = await MunicipioServico.ObterPorIdAsync(id);
            Assert.AreEqual(segundoNome, municipioConsultada.Nome);
        }

        [TestMethod]
        public async Task Quando_Excluir_Por_Id_Registro_Devera_Apagar_Registro_Async()
        {
            var id = await MunicipioServico.InserirAsync(new Municipio { UnidadeFederacaoId = _unidadeFederacao.Id, Nome = $"Cidade-{System.Guid.NewGuid()}" });
            var municipio = await MunicipioServico.ObterPorIdAsync(id);
            await MunicipioServico.ExcluirAsync(municipio.Id);
            municipio = await MunicipioServico.ObterPorIdAsync(municipio.Id);
            Assert.IsNull(municipio);
        }

        [TestMethod]
        public async Task Quando_Excluir_Por_Entidade_Registro_Devera_Apagar_Registro_Async()
        {
            var id = await MunicipioServico.InserirAsync(new Municipio { UnidadeFederacaoId = _unidadeFederacao.Id, Nome = $"Cidade-{System.Guid.NewGuid()}" });
            var municipio = await MunicipioServico.ObterPorIdAsync(id);
            await MunicipioServico.ExcluirAsync(municipio);
            municipio = await MunicipioServico.ObterPorIdAsync(id);
            Assert.IsNull(municipio);
        }

        [TestMethod]
        public async Task Quando_Obter_Por_Id_Registro_Devera_Ser_Consultado_Async()
        {
            var id = await MunicipioServico.InserirAsync(new Municipio { UnidadeFederacaoId = _unidadeFederacao.Id, Nome = $"Cidade-{System.Guid.NewGuid()}" });
            var municipio = await MunicipioServico.ObterPorIdAsync(id);
            Assert.AreEqual(id, municipio.Id);
        }

        [TestMethod]
        public async Task Quando_Obter_Registros_Deverao_Ser_Consultados_Async()
        {
            var identificadores = new List<int>();
            var id = await MunicipioServico.InserirAsync(new Municipio { UnidadeFederacaoId = _unidadeFederacao.Id, Nome = $"Cidade-{System.Guid.NewGuid()}" });
            identificadores.Add(id);
            id = await MunicipioServico.InserirAsync(new Municipio { UnidadeFederacaoId = _unidadeFederacao.Id, Nome = $"Cidade-{System.Guid.NewGuid()}" });
            identificadores.Add(id);
            var municipios = await MunicipioServico.ObterAsync(f => identificadores.Any(item => item == f.Id));
            Assert.AreEqual(2, municipios.Dados.Count);
        }
    }
}
