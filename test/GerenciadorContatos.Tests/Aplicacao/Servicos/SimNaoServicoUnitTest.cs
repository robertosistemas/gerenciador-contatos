using GerenciadorContatos.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace GerenciadorContatos.Tests.Aplicacao.Servicos
{
    [TestClass]
    public class SimNaoServicoUnitTest : DatabaseTesteBase
    {

        [TestMethod]
        public async Task Quando_Inserir_Um_Registro_Devera_Criar_Registro_Async()
        {
            var simNao = new SimNao { Valor = null, Texto = System.Guid.NewGuid().ToString().Substring(0, 10) };
            var simNaoInserido = await InserirSimNao(simNao);
            var simNaoConsultado = await SimNaoServico.ObterPorIdAsync(simNaoInserido.Id);
            Assert.AreEqual(simNaoInserido.Id, simNaoConsultado.Id);
        }

        [TestMethod]
        public async Task Quando_Inserir_Varios_Registros_Devera_Criar_Registros_Async()
        {
            var itens = new List<string>();
            var simsNaos = new List<SimNao>();

            var texto = System.Guid.NewGuid().ToString().Substring(0, 10);
            simsNaos.Add(new SimNao { Valor = null, Texto = texto });
            itens.Add(texto);

            texto = System.Guid.NewGuid().ToString().Substring(0, 10);
            simsNaos.Add(new SimNao { Valor = true, Texto = texto });
            itens.Add(texto);

            texto = System.Guid.NewGuid().ToString().Substring(0, 10);
            simsNaos.Add(new SimNao { Valor = false, Texto = texto });
            itens.Add(texto);

            await SimNaoServico.InserirAsync(simsNaos);

            var simsNaosConsultadas = await SimNaoServico.ObterAsync(f => itens.Any(item => item == f.Texto));

            Assert.AreEqual(3, simsNaosConsultadas.Dados.Count);
        }

        [TestMethod]
        public async Task Quando_Alterar_Devera_Modificar_Registro_Async()
        {
            var primeiroTexto = System.Guid.NewGuid().ToString().Substring(0, 10);
            var segundoTexto = System.Guid.NewGuid().ToString().Substring(0, 10);
            var simNao = new SimNao { Valor = true, Texto = primeiroTexto };
            var id = await SimNaoServico.InserirAsync(simNao);
            var simNaoConsultada = await SimNaoServico.ObterPorIdAsync(id);
            Assert.AreEqual(primeiroTexto, simNaoConsultada.Texto);
            simNaoConsultada.Texto = segundoTexto;
            await SimNaoServico.AtualizarAsync(simNaoConsultada);
            simNaoConsultada = await SimNaoServico.ObterPorIdAsync(id);
            Assert.AreEqual(segundoTexto, simNaoConsultada.Texto);
        }

        [TestMethod]
        public async Task Quando_Excluir_Por_Id_Registro_Devera_Apagar_Registro_Async()
        {
            var id = await SimNaoServico.InserirAsync(new SimNao { Valor = true, Texto = System.Guid.NewGuid().ToString().Substring(0, 10) });
            var simNao = await SimNaoServico.ObterPorIdAsync(id);
            await SimNaoServico.ExcluirAsync(simNao.Id);
            simNao = await SimNaoServico.ObterPorIdAsync(simNao.Id);
            Assert.IsNull(simNao);
        }

        [TestMethod]
        public async Task Quando_Excluir_Por_Entidade_Registro_Devera_Apagar_Registro_Async()
        {
            var id = await SimNaoServico.InserirAsync(new SimNao { Valor = true, Texto = System.Guid.NewGuid().ToString().Substring(0, 10) });
            var simNao = await SimNaoServico.ObterPorIdAsync(id);
            await SimNaoServico.ExcluirAsync(simNao);
            simNao = await SimNaoServico.ObterPorIdAsync(id);
            Assert.IsNull(simNao);
        }

        [TestMethod]
        public async Task Quando_Obter_Por_Id_Registro_Devera_Ser_Consultado_Async()
        {
            var id = await SimNaoServico.InserirAsync(new SimNao { Valor = true, Texto = System.Guid.NewGuid().ToString().Substring(0, 10) });
            var simNao = await SimNaoServico.ObterPorIdAsync(id);
            Assert.AreEqual(id, simNao.Id);
        }

        [TestMethod]
        public async Task Quando_Obter_Registros_Deverao_Ser_Consultados_Async()
        {
            var identificadores = new List<int>();
            var id = await SimNaoServico.InserirAsync(new SimNao { Valor = true, Texto = System.Guid.NewGuid().ToString().Substring(0, 10) });
            identificadores.Add(id);
            id = await SimNaoServico.InserirAsync(new SimNao { Valor = true, Texto = System.Guid.NewGuid().ToString().Substring(0, 10) });
            identificadores.Add(id);
            var simsNaos = await SimNaoServico.ObterAsync(f => identificadores.Any(item => item == f.Id));
            Assert.AreEqual(2, simsNaos.Dados.Count);
        }
    }
}
