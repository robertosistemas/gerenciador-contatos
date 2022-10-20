using AutoMapper;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Aplicacao.Servicos
{
    public class CartaoHistoricoServico : Servico<CartaoHistorico, int, CartaoHistoricoModelo>, ICartaoHistoricoServico
    {
        public CartaoHistoricoServico(IMapper mapper, ICartaoHistoricoRepositorio cartaoHistoricoRepositorio) : base(mapper, cartaoHistoricoRepositorio)
        {
        }
    }
}

