using GerenciadorContatos.Aplicacao;
using GerenciadorContatos.Aplicacao.Abstracoes.Excecoes;
using GerenciadorContatos.Aplicacao.Excecoes;
using GerenciadorContatos.Dominio;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SQLite;
using System.IO;

namespace GerenciadorContatos.Tests
{
    [TestClass]
    public class ConfiguraInicializacaoAssembly
    {
        const string OrigemDb = "GerenciadorContatosZero.db";
        const string DestinoDb = "GerenciadorContatosTestes.db";

        static ConfiguraInicializacaoAssembly()
        {
            Configuracao.StringConexao = $"Data Source={Configuracao.PathDatabase}{DestinoDb};Foreign Keys=True;";
            AutoMapeamento.InicializaAutoMapper();
            InjecaoDependencia.ConfigureServices();
            InjecaoDependencia.Services.AddTransient<IErrorHandler, ServicoErrorHandler>();
            InjecaoDependencia.ConstruirProvedorServico();
        }

        [AssemblyInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void AssemblyInit(TestContext context)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            var temp = Configuracao.StringConexao;
            try
            {
                ApagaDestinoSeExite();
                CopiaOrigemParaDestino();

                Configuracao.StringConexao = $"Data Source={Configuracao.PathDatabase}{DestinoDb};Foreign Keys=True;";

                //var configuration = new Configuration();
                //var migrator = new DbMigrator(configuration);
                //// back to 0
                //migrator.Update("0");
                //// up to current
                //migrator.Update();
                //// back to 0
                //migrator.Update("0");
            }
            finally
            {
                Configuracao.StringConexao = temp;
            }

        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            try
            {
                InjecaoDependencia.RemoveTodos();
                SQLiteConnection.ClearAllPools();
                //SQLiteConnectionPool.Shared.Reset()
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
            finally
            {
                ApagaDestinoSeExite();
            }
        }

        private static void CopiaOrigemParaDestino()
        {
            var origemDb = $"{Configuracao.PathDatabase}{OrigemDb}";
            var destinoDb = $"{Configuracao.PathDatabase}{DestinoDb}";
            File.Copy(origemDb, destinoDb, true);
        }

        private static void ApagaDestinoSeExite()
        {
            var destinoDb = $"{Configuracao.PathDatabase}{DestinoDb}";
            if (File.Exists(destinoDb))
                File.Delete(destinoDb);
        }

        [TestMethod]
        public void TesteInicializacao()
        {
            var destinoDb = $"{Configuracao.PathDatabase}{DestinoDb}";
            var arquivoExiste = File.Exists(destinoDb);
            Assert.AreEqual(true, arquivoExiste);
        }
    }
}
