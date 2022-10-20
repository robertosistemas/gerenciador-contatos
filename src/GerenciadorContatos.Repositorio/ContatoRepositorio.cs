using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Repositorio
{
    public class ContatoRepositorio : Repositorio<ContatoModelo, int>, IContatoRepositorio
    {
        public ContatoRepositorio(GerenciadorContatoDbContext gerenciadorContatoDbContext) : base(gerenciadorContatoDbContext)
        {
        }
    }
}
