using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Repositorio
{
    public class OperadoraRepositorio : Repositorio<OperadoraModelo, int>, IOperadoraRepositorio
    {
        public OperadoraRepositorio(GerenciadorContatoDbContext gerenciadorContatoDbContext) : base(gerenciadorContatoDbContext)
        {
        }
    }
}
