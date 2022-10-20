using AutoMapper;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Aplicacao.Servicos
{
    public class UnidadeFederacaoServico : Servico<UnidadeFederacao, int, UnidadeFederacaoModelo>, IUnidadeFederacaoServico
    {
        public UnidadeFederacaoServico(IMapper mapper, IUnidadeFederacaoRepositorio unidadeFederacaoRepositorio) : base(mapper, unidadeFederacaoRepositorio)
        {
        }
    }
}
