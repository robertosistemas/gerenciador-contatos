using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;

namespace GerenciadorContatos.Repositorio
{
    public class SequenciaNumericaRepositorio : Repositorio<SequenciaNumericaModelo, int>, ISequenciaNumericaRepositorio
    {
        public SequenciaNumericaRepositorio(GerenciadorContatoDbContext gerenciadorContatoDbContext) : base(gerenciadorContatoDbContext)
        {
        }
    }
}
