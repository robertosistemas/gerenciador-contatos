using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using GerenciadorContatos.Aplicacao.Profiles;

namespace GerenciadorContatos.Aplicacao
{
    public static class AutoMapeamento
    {
        public static MapperConfiguration Configuracao;
        public static void InicializaAutoMapper()
        {
            Configuracao = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping();
                cfg.AddProfile<CartaoProfile>();
                cfg.AddProfile<CartaoHistoricoProfile>();
                cfg.AddProfile<CongregacaoProfile>();
                cfg.AddProfile<ContatoProfile>();
                cfg.AddProfile<ContatoHistoricoProfile>();
                cfg.AddProfile<MunicipioProfile>();
                cfg.AddProfile<OperadoraProfile>();
                cfg.AddProfile<PublicadorProfile>();
                cfg.AddProfile<SequenciaNumericaProfile>();
                cfg.AddProfile<UnidadeFederacaoProfile>();
                cfg.AddProfile<SimNaoProfile>();
                cfg.AddProfile<ContainerDadosProfile>();
            });
            Configuracao.AssertConfigurationIsValid();
        }

        public static T Map<T>(object source) => Configuracao.CreateMapper().Map<T>(source);
    }
}
