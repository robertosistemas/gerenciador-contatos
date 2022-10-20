using AutoMapper;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Aplicacao.Servicos
{
    public class ContatoHistoricoServico : Servico<ContatoHistorico, int, ContatoHistoricoModelo>, IContatoHistoricoServico
    {
        public ContatoHistoricoServico(IMapper mapper, IContatoHistoricoRepositorio contatoHistoricoRepositorio) : base(mapper, contatoHistoricoRepositorio)
        {
        }
    }
}

