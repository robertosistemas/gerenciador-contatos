using System.Collections.Generic;

namespace GerenciadorContatos.Modelos
{
    public class PublicadorModelo : ModeloBase<int>
    {
        public int CongregacaoId { get; set; }
        public string Nome { get; set; }

        public CongregacaoModelo Congregacao { get; set; }
        public List<CartaoHistoricoModelo> CartoesHistoricos { get; set; }
        public List<ContatoHistoricoModelo> ContatosHistoricos { get; set; }
        public List<CartaoModelo> Cartoes { get; set; }
    }
}
