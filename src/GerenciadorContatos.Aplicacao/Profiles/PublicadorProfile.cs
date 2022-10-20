using AutoMapper;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;

namespace GerenciadorContatos.Aplicacao.Profiles
{
    public class PublicadorProfile : Profile
    {
        public PublicadorProfile()
        {
            CreateMap<Publicador, PublicadorModelo>();
            CreateMap<PublicadorModelo, Publicador>();
        }
    }
}
