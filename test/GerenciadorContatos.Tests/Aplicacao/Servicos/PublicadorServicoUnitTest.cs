using GerenciadorContatos.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace GerenciadorContatos.Tests.Aplicacao.Servicos
{
    [TestClass]
    public class PublicadorServicoUnitTest : DatabaseTesteBase
    {
        private Congregacao _congregacao;

        [TestInitialize]
        public async Task SetUp()
        {
            if (_congregacao == null)
            {
                _congregacao = await CriarCongregacaoAsync();
            }
        }

        [TestMethod]
        public async Task Quando_Inserir_Um_Registro_Devera_Criar_Registro_Async()
        {
            var id = await PublicadorServico.InserirAsync(new Publicador { CongregacaoId = _congregacao.Id, Nome = $"Associado-{System.Guid.NewGuid()}" });
            var publicador = await PublicadorServico.ObterPorIdAsync(id);
            Assert.AreEqual(id, publicador.Id);
        }

        [TestMethod]
        public async Task Quando_Inserir_Varios_Registros_Devera_Criar_Registros_Async()
        {
            var nomes = new List<string>();
            var publicadores = new List<Publicador>();

            var nome = $"João-{System.Guid.NewGuid()}";
            publicadores.Add(new Publicador { CongregacaoId = _congregacao.Id, Nome = nome });
            nomes.Add(nome);

            nome = $"Maria-{System.Guid.NewGuid()}";
            publicadores.Add(new Publicador { CongregacaoId = _congregacao.Id, Nome = nome });
            nomes.Add(nome);

            nome = $"José-{System.Guid.NewGuid()}";
            publicadores.Add(new Publicador { CongregacaoId = _congregacao.Id, Nome = nome });
            nomes.Add(nome);

            nome = $"Pedro-{System.Guid.NewGuid()}";
            publicadores.Add(new Publicador { CongregacaoId = _congregacao.Id, Nome = nome });
            nomes.Add(nome);

            await PublicadorServico.InserirAsync(publicadores);

            var publicadoresConsultadas = await PublicadorServico.ObterAsync(f => nomes.Any(item => item == f.Nome));

            Assert.AreEqual(4, publicadoresConsultadas.Dados.Count);
        }

        [TestMethod]
        public async Task Quando_Alterar_Devera_Modificar_Registro_Async()
        {
            var primeiroNome = $"João-{System.Guid.NewGuid()}";
            var segundoNome = $"João da Silva-{System.Guid.NewGuid()}";
            var publicador = new Publicador { CongregacaoId = _congregacao.Id, Nome = primeiroNome };
            var id = await PublicadorServico.InserirAsync(publicador);
            var publicadorConsultado = await PublicadorServico.ObterPorIdAsync(id);
            Assert.AreEqual(primeiroNome, publicadorConsultado.Nome);
            publicadorConsultado.Nome = segundoNome;
            await PublicadorServico.AtualizarAsync(publicadorConsultado);
            publicadorConsultado = await PublicadorServico.ObterPorIdAsync(id);
            Assert.AreEqual(segundoNome, publicadorConsultado.Nome);
        }

        [TestMethod]
        public async Task Quando_Excluir_Por_Id_Registro_Devera_Apagar_Registro_Async()
        {
            var id = await PublicadorServico.InserirAsync(new Publicador { CongregacaoId = _congregacao.Id, Nome = $"Associado-{System.Guid.NewGuid()}" });
            var publicador = await PublicadorServico.ObterPorIdAsync(id);
            await PublicadorServico.ExcluirAsync(publicador.Id);
            publicador = await PublicadorServico.ObterPorIdAsync(publicador.Id);
            Assert.IsNull(publicador);
        }

        [TestMethod]
        public async Task Quando_Excluir_Por_Entidade_Registro_Devera_Apagar_Registro_Async()
        {
            var id = await PublicadorServico.InserirAsync(new Publicador { CongregacaoId = _congregacao.Id, Nome = $"Associado-{System.Guid.NewGuid()}" });
            var publicador = await PublicadorServico.ObterPorIdAsync(id);
            await PublicadorServico.ExcluirAsync(publicador);
            publicador = await PublicadorServico.ObterPorIdAsync(id);
            Assert.IsNull(publicador);
        }

        [TestMethod]
        public async Task Quando_Obter_Por_Id_Registro_Devera_Ser_Consultado_Async()
        {
            var id = await PublicadorServico.InserirAsync(new Publicador { CongregacaoId = _congregacao.Id, Nome = $"Associado-{System.Guid.NewGuid()}" });
            var publicador = await PublicadorServico.ObterPorIdAsync(id);
            Assert.AreEqual(id, publicador.Id);
        }

        [TestMethod]
        public async Task Quando_Obter_Registros_Deverao_Ser_Consultados_Async()
        {
            var identificadores = new List<int>();
            var id = await PublicadorServico.InserirAsync(new Publicador { CongregacaoId = _congregacao.Id, Nome = $"Associado-{System.Guid.NewGuid()}" });
            identificadores.Add(id);
            id = await PublicadorServico.InserirAsync(new Publicador { CongregacaoId = _congregacao.Id, Nome = $"Associado-{System.Guid.NewGuid()}" });
            identificadores.Add(id);
            var publicadores = await PublicadorServico.ObterAsync(f => identificadores.Any(item => item == f.Id));
            Assert.AreEqual(2, publicadores.Dados.Count);
        }
    }
}
