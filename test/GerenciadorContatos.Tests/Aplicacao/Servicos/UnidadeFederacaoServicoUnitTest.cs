using GerenciadorContatos.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace GerenciadorContatos.Tests.Aplicacao.Servicos
{
    [TestClass]
    public class UnidadeFederacaoServicoUnitTest : DatabaseTesteBase
    {

        [TestMethod]
        public async Task Quando_Inserir_Um_Registro_Devera_Criar_Registro_Async()
        {
            var id = await UnidadeFederacaoServico.InserirAsync(new UnidadeFederacao { Sigla = "TO", Nome = "Tocantins" });
            var unidadeFederacao = await UnidadeFederacaoServico.ObterPorIdAsync(id);
            Assert.AreEqual(id, unidadeFederacao.Id);
        }

        [TestMethod]
        public async Task Quando_Inserir_Varios_Registros_Devera_Criar_Registros_Async()
        {
            var siglas = new List<string>();
            var unidadeFederacaos = new List<UnidadeFederacao>();

            var sigla = "AC";
            unidadeFederacaos.Add(new UnidadeFederacao { Sigla = sigla, Nome = "Acre" });
            siglas.Add(sigla);

            sigla = "RJ";
            unidadeFederacaos.Add(new UnidadeFederacao { Sigla = sigla, Nome = "Rio de Janeiro" });
            siglas.Add(sigla);

            sigla = "MG";
            unidadeFederacaos.Add(new UnidadeFederacao { Sigla = sigla, Nome = "Minas Gerais" });
            siglas.Add(sigla);

            sigla = "SP";
            unidadeFederacaos.Add(new UnidadeFederacao { Sigla = sigla, Nome = "São Paulo" });
            siglas.Add(sigla);

            await UnidadeFederacaoServico.InserirAsync(unidadeFederacaos);

            var unidadesFederacoesConsultadas = await UnidadeFederacaoServico.ObterAsync(f => siglas.Any(item => item == f.Sigla));

            Assert.AreEqual(4, unidadesFederacoesConsultadas.Dados.Count);
        }

        [TestMethod]
        public async Task Quando_Alterar_Devera_Modificar_Registro_Async()
        {
            var primeiroNome = "Mato";
            var segundoNome = "Mato Grosso";
            var unidadeFederacao = new UnidadeFederacao { Sigla = "MT", Nome = primeiroNome };
            var id = await UnidadeFederacaoServico.InserirAsync(unidadeFederacao);
            var unidadeFederacaoConsultada = await UnidadeFederacaoServico.ObterPorIdAsync(id);
            Assert.AreEqual(primeiroNome, unidadeFederacaoConsultada.Nome);
            unidadeFederacaoConsultada.Nome = segundoNome;
            await UnidadeFederacaoServico.AtualizarAsync(unidadeFederacaoConsultada);
            unidadeFederacaoConsultada = await UnidadeFederacaoServico.ObterPorIdAsync(id);
            Assert.AreEqual(segundoNome, unidadeFederacaoConsultada.Nome);
        }

        [TestMethod]
        public async Task Quando_Excluir_Por_Id_Registro_Devera_Apagar_Registro_Async()
        {
            var id = await UnidadeFederacaoServico.InserirAsync(new UnidadeFederacao { Sigla = "AM", Nome = "Amazonas" });
            var unidadeFederacao = await UnidadeFederacaoServico.ObterPorIdAsync(id);
            await UnidadeFederacaoServico.ExcluirAsync(unidadeFederacao.Id);
            unidadeFederacao = await UnidadeFederacaoServico.ObterPorIdAsync(unidadeFederacao.Id);
            Assert.IsNull(unidadeFederacao);
        }

        [TestMethod]
        public async Task Quando_Excluir_Por_Entidade_Registro_Devera_Apagar_Registro_Async()
        {
            var id = await UnidadeFederacaoServico.InserirAsync(new UnidadeFederacao { Sigla = "RS", Nome = "Rio Grande do Sul" });
            var unidadeFederacao = await UnidadeFederacaoServico.ObterPorIdAsync(id);
            await UnidadeFederacaoServico.ExcluirAsync(unidadeFederacao);
            unidadeFederacao = await UnidadeFederacaoServico.ObterPorIdAsync(id);
            Assert.IsNull(unidadeFederacao);
        }

        [TestMethod]
        public async Task Quando_Obter_Por_Id_Registro_Devera_Ser_Consultado_Async()
        {
            var id = await UnidadeFederacaoServico.InserirAsync(new UnidadeFederacao { Sigla = "GO", Nome = "Goiás" });
            var unidadeFederacao = await UnidadeFederacaoServico.ObterPorIdAsync(id);
            Assert.AreEqual(id, unidadeFederacao.Id);
        }

        [TestMethod]
        public async Task Quando_Obter_Registros_Deverao_Ser_Consultados_Async()
        {
            var identificadores = new List<int>();
            var id = await UnidadeFederacaoServico.InserirAsync(new UnidadeFederacao { Sigla = "PE", Nome = "Pernambuco" });
            identificadores.Add(id);
            id = await UnidadeFederacaoServico.InserirAsync(new UnidadeFederacao { Sigla = "AL", Nome = "Alagoas" });
            identificadores.Add(id);
            var unidadesFederacoes = await UnidadeFederacaoServico.ObterAsync(f => identificadores.Any(item => item == f.Id));
            Assert.AreEqual(2, unidadesFederacoes.Dados.Count);
        }
    }
}
