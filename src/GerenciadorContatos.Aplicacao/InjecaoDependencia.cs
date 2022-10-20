using AutoMapper;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Aplicacao.Servicos;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Repositorio;
using GerenciadorContatos.Repositorio.Abstracoes;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GerenciadorContatos.Aplicacao
{
    public static class InjecaoDependencia
    {
        public static ServiceCollection Services { get; private set; }
        public static IServiceProvider ServiceProvider { get; private set; }
        public static IServiceScope ServiceScope { get; private set; }

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();

            Services.AddSingleton<IMapper>(provider => new Mapper(AutoMapeamento.Configuracao));
            //Services.AddTransient<DbConnection>(provider => new SQLiteConnection(Configuracao.StringConexao));
            Services.AddTransient<GerenciadorContatoDbContext>();
            //Services.AddTransient<GerenciadorContatoDbContext>(provider => new GerenciadorContatoDbContext(new SQLiteConnection(Configuracao.StringConexao), true));

            Services.AddTransient<InformacaoPagina>();

            Services.AddTransient(typeof(IRepositorio<,>), typeof(Repositorio<,>));

            Services.AddTransient<ICartaoHistoricoRepositorio, CartaoHistoricoRepositorio>();
            Services.AddTransient<ICartaoRepositorio, CartaoRepositorio>();
            Services.AddTransient<ICongregacaoRepositorio, CongregacaoRepositorio>();
            Services.AddTransient<IContatoHistoricoRepositorio, ContatoHistoricoRepositorio>();
            Services.AddTransient<IContatoRepositorio, ContatoRepositorio>();
            Services.AddTransient<IMunicipioRepositorio, MunicipioRepositorio>();
            Services.AddTransient<IOperadoraRepositorio, OperadoraRepositorio>();
            Services.AddTransient<IPublicadorRepositorio, PublicadorRepositorio>();
            Services.AddTransient<ISequenciaNumericaRepositorio, SequenciaNumericaRepositorio>();
            Services.AddTransient<ISimNaoRepositorio, SimNaoRepositorio>();
            Services.AddTransient<IUnidadeFederacaoRepositorio, UnidadeFederacaoRepositorio>();

            Services.AddTransient<IUnidadeDeTrabalho, UnidadeDeTrabalho>();

            Services.AddTransient(typeof(IServico<,,>), typeof(Servico<,,>));

            Services.AddTransient<ICartaoHistoricoServico, CartaoHistoricoServico>();
            Services.AddTransient<ICartaoServico, CartaoServico>();
            Services.AddTransient<ICongregacaoServico, CongregacaoServico>();
            Services.AddTransient<IContatoHistoricoServico, ContatoHistoricoServico>();
            Services.AddTransient<IContatoServico, ContatoServico>();
            Services.AddTransient<IMunicipioServico, MunicipioServico>();
            Services.AddTransient<IOperadoraServico, OperadoraServico>();
            Services.AddTransient<IPublicadorServico, PublicadorServico>();
            Services.AddTransient<ISequenciaNumericaServico, SequenciaNumericaServico>();
            Services.AddTransient<ISimNaoServico, SimNaoServico>();
            Services.AddTransient<IUnidadeFederacaoServico, UnidadeFederacaoServico>();

            //ConstruirProvedorServico();
        }

        public static void ConstruirProvedorServico()
        {
            ServiceProvider = Services.BuildServiceProvider();
            ServiceScope = ServiceProvider.CreateScope();
        }

        public static T GetService<T>() => (T)ServiceScope.ServiceProvider.GetService<T>();

        public static void RemoveTodos()
        {
            ServiceScope.Dispose();
        }
    }
}
