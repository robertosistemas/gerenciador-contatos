using GerenciadorContatos.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace GerenciadorContatos.Tests.Aplicacao.Servicos
{
    [TestClass]
    public class CongregacaoServicoUnitTest : DatabaseTesteBase
    {
        private Municipio _municipio;

        [TestInitialize]
        public async Task SetUp()
        {
            if (_municipio == null)
            {
                _municipio = await CriarMunicipioAsync();
            }
        }

        [TestMethod]
        public async Task Quando_Inserir_Um_Registro_Devera_Criar_Registro_Async()
        {
            var id = await CongregacaoServico.InserirAsync(new Congregacao { MunicipioId = _municipio.Id, Numero = ObtemId(), Nome = $"Associacao-{System.Guid.NewGuid()}" });
            var congregacao = await CongregacaoServico.ObterPorIdAsync(id);
            Assert.AreEqual(id, congregacao.Id);
        }

        [TestMethod]
        public async Task Quando_Inserir_Varios_Registros_Devera_Criar_Registros_Async()
        {
            var nomes = new List<string>();
            var congregacaos = new List<Congregacao>();

            var nome = $"Cachoeira-{System.Guid.NewGuid()}";
            congregacaos.Add(new Congregacao { MunicipioId = _municipio.Id, Numero = ObtemId(), Nome = nome });
            nomes.Add(nome);

            nome = $"Canasvieiras-{System.Guid.NewGuid()}";
            congregacaos.Add(new Congregacao { MunicipioId = _municipio.Id, Numero = ObtemId(), Nome = nome });
            nomes.Add(nome);

            nome = $"Ingleses-{System.Guid.NewGuid()}";
            congregacaos.Add(new Congregacao { MunicipioId = _municipio.Id, Numero = ObtemId(), Nome = nome });
            nomes.Add(nome);

            nome = $"Central-{System.Guid.NewGuid()}";
            congregacaos.Add(new Congregacao { MunicipioId = _municipio.Id, Numero = ObtemId(), Nome = nome });
            nomes.Add(nome);

            await CongregacaoServico.InserirAsync(congregacaos);

            var congregacaosConsultadas = await CongregacaoServico.ObterAsync(f => nomes.Any(item => item == f.Nome));

            Assert.AreEqual(4, congregacaosConsultadas.Dados.Count);
        }

        [TestMethod]
        public async Task Quando_Alterar_Devera_Modificar_Registro_Async()
        {
            var primeiroNome = $"Cachoeira-{System.Guid.NewGuid()}";
            var segundoNome = $"Cachoeira do bom Jesus-{System.Guid.NewGuid()}";
            var congregacao = new Congregacao { MunicipioId = _municipio.Id, Numero = ObtemId(), Nome = primeiroNome };
            var id = await CongregacaoServico.InserirAsync(congregacao);
            var congregacaoConsultada = await CongregacaoServico.ObterPorIdAsync(id);
            Assert.AreEqual(primeiroNome, congregacaoConsultada.Nome);
            congregacaoConsultada.Nome = segundoNome;
            await CongregacaoServico.AtualizarAsync(congregacaoConsultada);
            congregacaoConsultada = await CongregacaoServico.ObterPorIdAsync(id);
            Assert.AreEqual(segundoNome, congregacaoConsultada.Nome);
        }

        [TestMethod]
        public async Task Quando_Excluir_Por_Id_Registro_Devera_Apagar_Registro_Async()
        {
            var id = await CongregacaoServico.InserirAsync(new Congregacao { MunicipioId = _municipio.Id, Numero = ObtemId(), Nome = $"Associacao-{System.Guid.NewGuid()}" });
            var congregacao = await CongregacaoServico.ObterPorIdAsync(id);
            await CongregacaoServico.ExcluirAsync(congregacao.Id);
            congregacao = await CongregacaoServico.ObterPorIdAsync(congregacao.Id);
            Assert.IsNull(congregacao);
        }

        [TestMethod]
        public async Task Quando_Excluir_Por_Entidade_Registro_Devera_Apagar_Registro_Async()
        {
            var id = await CongregacaoServico.InserirAsync(new Congregacao { MunicipioId = _municipio.Id, Numero = ObtemId(), Nome = $"Associacao-{System.Guid.NewGuid()}" });
            var congregacao = await CongregacaoServico.ObterPorIdAsync(id);
            await CongregacaoServico.ExcluirAsync(congregacao);
            congregacao = await CongregacaoServico.ObterPorIdAsync(id);
            Assert.IsNull(congregacao);
        }

        [TestMethod]
        public async Task Quando_Obter_Por_Id_Registro_Devera_Ser_Consultado_Async()
        {
            var id = await CongregacaoServico.InserirAsync(new Congregacao { MunicipioId = _municipio.Id, Numero = ObtemId(), Nome = $"Associacao-{System.Guid.NewGuid()}" });
            var congregacao = await CongregacaoServico.ObterPorIdAsync(id);
            Assert.AreEqual(id, congregacao.Id);
        }

        [TestMethod]
        public async Task Quando_Obter_Registros_Deverao_Ser_Consultados_Async()
        {
            var identificadores = new List<int>();
            var id = await CongregacaoServico.InserirAsync(new Congregacao { MunicipioId = _municipio.Id, Numero = ObtemId(), Nome = $"Associacao-{System.Guid.NewGuid()}" });
            identificadores.Add(id);
            id = await CongregacaoServico.InserirAsync(new Congregacao { MunicipioId = _municipio.Id, Numero = ObtemId(), Nome = $"Associacao-{System.Guid.NewGuid()}" });
            identificadores.Add(id);
            var congregacoes = await CongregacaoServico.ObterAsync(f => identificadores.Any(item => item == f.Id));
            Assert.AreEqual(2, congregacoes.Dados.Count);
        }
    }
}
