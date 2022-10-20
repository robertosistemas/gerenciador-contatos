using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Repositorio
{
    public class UnidadeFederacaoRepositorio : Repositorio<UnidadeFederacaoModelo, int>, IUnidadeFederacaoRepositorio
    {
        public UnidadeFederacaoRepositorio(GerenciadorContatoDbContext gerenciadorContatoDbContext) : base(gerenciadorContatoDbContext)
        {
        }
    }
}
