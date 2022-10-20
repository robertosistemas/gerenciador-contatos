using AutoMapper;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Aplicacao.Servicos
{
    public class ContatoServico : Servico<Contato, int, ContatoModelo>, IContatoServico
    {
        public ContatoServico(IMapper mapper, IContatoRepositorio contatoRepositorio) : base(mapper, contatoRepositorio)
        {
        }
    }
}

