using AutoMapper;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Aplicacao.Servicos
{
    public class OperadoraServico : Servico<Operadora, int, OperadoraModelo>, IOperadoraServico
    {
        public OperadoraServico(IMapper mapper, IOperadoraRepositorio operadoraRepositorio) : base(mapper, operadoraRepositorio)
        {
        }
    }
}
