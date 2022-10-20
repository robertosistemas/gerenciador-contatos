using System.Collections.Generic;

namespace GerenciadorContatos.Modelos
{
    public class ContatoModelo : ModeloBase<int>
    {
        public int OperadoraId { get; set; }
        public int CartaoId { get; set; }
        public string Numero { get; set; }
        public bool PermiteLigar { get; set; }
        public string Nome { get; set; }
        public string Observacao { get; set; }

        public OperadoraModelo Operadora { get; set; }
        public CartaoModelo Cartao { get; set; }
        public List<ContatoHistoricoModelo> ContatosHistoricos { get; set; }
    }
}
