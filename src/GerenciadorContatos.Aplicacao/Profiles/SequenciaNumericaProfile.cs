using AutoMapper;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;

namespace GerenciadorContatos.Aplicacao.Profiles
{
    public class SequenciaNumericaProfile : Profile
    {
        public SequenciaNumericaProfile()
        {
            CreateMap<SequenciaNumerica, SequenciaNumericaModelo>();
            CreateMap<SequenciaNumericaModelo, SequenciaNumerica>();
        }
    }
}
