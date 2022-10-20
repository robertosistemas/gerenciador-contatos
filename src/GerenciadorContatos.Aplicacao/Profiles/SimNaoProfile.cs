using AutoMapper;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;

namespace GerenciadorContatos.Aplicacao.Profiles
{
    public class SimNaoProfile : Profile
    {
        public SimNaoProfile()
        {
            CreateMap<SimNao, SimNaoModelo>();
            CreateMap<SimNaoModelo, SimNao>();
        }
    }
}
