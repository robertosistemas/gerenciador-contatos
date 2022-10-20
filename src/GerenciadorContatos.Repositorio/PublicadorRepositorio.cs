using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Repositorio
{
    public class PublicadorRepositorio : Repositorio<PublicadorModelo, int>, IPublicadorRepositorio
    {
        public PublicadorRepositorio(GerenciadorContatoDbContext gerenciadorContatoDbContext) : base(gerenciadorContatoDbContext)
        {
        }
    }
}
