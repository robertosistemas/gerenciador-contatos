using AutoMapper;
using GerenciadorContatos.Dominio;

namespace GerenciadorContatos.Aplicacao.Profiles
{
    public class ContainerDadosProfile : Profile
    {
        public ContainerDadosProfile()
        {
            CreateMap(typeof(ContainerDados<>), typeof(ContainerDados<>));
        }
    }
}
