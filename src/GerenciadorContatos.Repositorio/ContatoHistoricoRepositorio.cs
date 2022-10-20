using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Repositorio
{
    public class ContatoHistoricoRepositorio : Repositorio<ContatoHistoricoModelo, int>, IContatoHistoricoRepositorio
    {
        public ContatoHistoricoRepositorio(GerenciadorContatoDbContext gerenciadorContatoDbContext) : base(gerenciadorContatoDbContext)
        {
        }
    }
}
