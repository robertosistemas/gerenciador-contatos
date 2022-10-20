using GerenciadorContatos.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace GerenciadorContatos.Tests.Aplicacao.Servicos
{
    [TestClass]
    public class OperadoraServicoUnitTest : DatabaseTesteBase
    {

        [TestMethod]
        public async Task Quando_Inserir_Um_Registro_Devera_Criar_Registro_Async()
        {
            var id = await OperadoraServico.InserirAsync(new Operadora { Codigo = ObtemId(), Nome = "Inserir" });
            var operadora = await OperadoraServico.ObterPorIdAsync(id);
            Assert.AreEqual(id, operadora.Id);
        }

        [TestMethod]
        public async Task Quando_Inserir_Varios_Registros_Devera_Criar_Registros_Async()
        {
            var codigos = new List<int>();
            var operadoras = new List<Operadora>();

            var codigo = ObtemId();
            operadoras.Add(new Operadora { Codigo = codigo, Nome = "Primeiro" });
            codigos.Add(codigo);

            codigo = ObtemId();
            operadoras.Add(new Operadora { Codigo = codigo, Nome = "Segundo" });
            codigos.Add(codigo);

            codigo = ObtemId();
            operadoras.Add(new Operadora { Codigo = codigo, Nome = "Terceiro" });
            codigos.Add(codigo);

            codigo = ObtemId();
            operadoras.Add(new Operadora { Codigo = codigo, Nome = "Quarto" });
            codigos.Add(codigo);

            await OperadoraServico.InserirAsync(operadoras);

            var operadorasConsultadas = await OperadoraServico.ObterAsync(f => codigos.Any(item => item == f.Codigo));

            Assert.AreEqual(4, operadorasConsultadas.Dados.Count);
        }

        [TestMethod]
        public async Task Quando_Alterar_Devera_Modificar_Registro_Async()
        {
            var primeiroNome = "Primeiro Nome";
            var segundoNome = "Segundo Nome";
            var operadora = new Operadora { Codigo = ObtemId(), Nome = primeiroNome };
            var id = await OperadoraServico.InserirAsync(operadora);
            var operadoraConsultada = await OperadoraServico.ObterPorIdAsync(id);
            Assert.AreEqual(primeiroNome, operadoraConsultada.Nome);
            operadoraConsultada.Nome = segundoNome;
            await OperadoraServico.AtualizarAsync(operadoraConsultada);
            operadoraConsultada = await OperadoraServico.ObterPorIdAsync(id);
            Assert.AreEqual(segundoNome, operadoraConsultada.Nome);
        }

        [TestMethod]
        public async Task Quando_Excluir_Por_Id_Registro_Devera_Apagar_Registro_Async()
        {
            var id = await OperadoraServico.InserirAsync(new Operadora { Codigo = ObtemId(), Nome = "Excluir_Por_Id" });
            var operadora = await OperadoraServico.ObterPorIdAsync(id);
            await OperadoraServico.ExcluirAsync(operadora.Id);
            operadora = await OperadoraServico.ObterPorIdAsync(operadora.Id);
            Assert.IsNull(operadora);
        }

        [TestMethod]
        public async Task Quando_Excluir_Por_Entidade_Registro_Devera_Apagar_Registro_Async()
        {
            var id = await OperadoraServico.InserirAsync(new Operadora { Codigo = ObtemId(), Nome = "Excluir_Por_Entidade" });
            var operadora = await OperadoraServico.ObterPorIdAsync(id);
            await OperadoraServico.ExcluirAsync(operadora);
            operadora = await OperadoraServico.ObterPorIdAsync(id);
            Assert.IsNull(operadora);
        }

        [TestMethod]
        public async Task Quando_Obter_Por_Id_Registro_Devera_Ser_Consultado_Async()
        {
            var id = await OperadoraServico.InserirAsync(new Operadora { Codigo = ObtemId(), Nome = "Obter_Por_Id" });
            var operadora = await OperadoraServico.ObterPorIdAsync(id);
            Assert.AreEqual(id, operadora.Id);
        }

        [TestMethod]
        public async Task Quando_Obter_Registros_Deverao_Ser_Consultados_Async()
        {
            var identificadores = new List<int>();
            var id = await OperadoraServico.InserirAsync(new Operadora { Codigo = ObtemId(), Nome = "Primeiro" });
            identificadores.Add(id);
            id = await OperadoraServico.InserirAsync(new Operadora { Codigo = ObtemId(), Nome = "Segundo" });
            identificadores.Add(id);
            var operadoras = await OperadoraServico.ObterAsync(f => identificadores.Any(item => item == f.Id));
            Assert.AreEqual(2, operadoras.Dados.Count);
        }
    }
}
