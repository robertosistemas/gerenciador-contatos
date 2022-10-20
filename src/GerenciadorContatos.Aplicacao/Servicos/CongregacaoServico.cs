using AutoMapper;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Aplicacao.Servicos
{
    public class CongregacaoServico : Servico<Congregacao, int, CongregacaoModelo>, ICongregacaoServico
    {
        public CongregacaoServico(IMapper mapper, ICongregacaoRepositorio congregacaoRepositorio) : base(mapper, congregacaoRepositorio)
        {
        }
    }
}

