using AutoMapper;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Aplicacao.Servicos
{
    public class PublicadorServico : Servico<Publicador, int, PublicadorModelo>, IPublicadorServico
    {
        public PublicadorServico(IMapper mapper, IPublicadorRepositorio publicadorRepositorio) : base(mapper, publicadorRepositorio)
        {
        }
    }
}
