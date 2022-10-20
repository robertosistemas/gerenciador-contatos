using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Repositorio
{
    public class CartaoHistoricoRepositorio : Repositorio<CartaoHistoricoModelo, int>, ICartaoHistoricoRepositorio
    {
        public CartaoHistoricoRepositorio(GerenciadorContatoDbContext gerenciadorContatoDbContext) : base(gerenciadorContatoDbContext)
        {
        }
    }
}
