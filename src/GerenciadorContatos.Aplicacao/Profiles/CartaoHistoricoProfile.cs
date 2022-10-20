using AutoMapper;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;

namespace GerenciadorContatos.Aplicacao.Profiles
{
    public class CartaoHistoricoProfile : Profile
    {
        public CartaoHistoricoProfile()
        {
            CreateMap<CartaoHistorico, CartaoHistoricoModelo>();
            CreateMap<CartaoHistoricoModelo, CartaoHistorico>();
        }
    }
}
