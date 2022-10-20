using AutoMapper;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;

namespace GerenciadorContatos.Aplicacao.Profiles
{
    public class ContatoHistoricoProfile : Profile
    {
        public ContatoHistoricoProfile()
        {
            CreateMap<ContatoHistorico, ContatoHistoricoModelo>();
            CreateMap<ContatoHistoricoModelo, ContatoHistorico>();
        }
    }
}
