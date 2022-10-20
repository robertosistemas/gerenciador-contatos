using AutoMapper;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;

namespace GerenciadorContatos.Aplicacao.Profiles
{
    public class MunicipioProfile : Profile
    {
        public MunicipioProfile()
        {
            CreateMap<Municipio, MunicipioModelo>();
            CreateMap<MunicipioModelo, Municipio>();
        }
    }
}
