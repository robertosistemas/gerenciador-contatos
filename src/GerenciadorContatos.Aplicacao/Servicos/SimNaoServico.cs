using AutoMapper;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Aplicacao.Servicos
{
    public class SimNaoServico : Servico<SimNao, int, SimNaoModelo>, ISimNaoServico
    {
        public SimNaoServico(IMapper mapper, ISimNaoRepositorio simNaoRepositorio) : base(mapper, simNaoRepositorio)
        {
        }
    }
}
