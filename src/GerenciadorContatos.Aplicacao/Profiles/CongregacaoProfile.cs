using AutoMapper;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;

namespace GerenciadorContatos.Aplicacao.Profiles
{
    public class CongregacaoProfile : Profile
    {
        public CongregacaoProfile()
        {
            CreateMap<Congregacao, CongregacaoModelo>();
            CreateMap<CongregacaoModelo, Congregacao>();
        }
    }
}
