using AutoMapper;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Aplicacao.Servicos
{
    public class MunicipioServico : Servico<Municipio, int, MunicipioModelo>, IMunicipioServico
    {
        public MunicipioServico(IMapper mapper, IMunicipioRepositorio municipioRepositorio) : base(mapper, municipioRepositorio)
        {
        }
    }
}

