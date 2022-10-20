using AutoMapper;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;

namespace GerenciadorContatos.Aplicacao.Profiles
{
    public class OperadoraProfile : Profile
    {
        public OperadoraProfile()
        {
            CreateMap<Operadora, OperadoraModelo>();
            CreateMap<OperadoraModelo, Operadora>();
        }
    }
}
