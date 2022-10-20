using AutoMapper;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;

namespace GerenciadorContatos.Aplicacao.Profiles
{
    public class UnidadeFederacaoProfile : Profile
    {
        public UnidadeFederacaoProfile()
        {
            CreateMap<UnidadeFederacao, UnidadeFederacaoModelo>();
            CreateMap<UnidadeFederacaoModelo, UnidadeFederacao>();
        }
    }
}
