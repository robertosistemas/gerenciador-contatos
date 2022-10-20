using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Repositorio
{
    public class CartaoRepositorio : Repositorio<CartaoModelo, int>, ICartaoRepositorio
    {
        public CartaoRepositorio(GerenciadorContatoDbContext gerenciadorContatoDbContext) : base(gerenciadorContatoDbContext)
        {
        }
    }
}
