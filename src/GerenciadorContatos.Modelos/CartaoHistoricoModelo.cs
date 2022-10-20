using System;

namespace GerenciadorContatos.Modelos
{
    public class CartaoHistoricoModelo : ModeloBase<int>
    {
        public int CartaoId { get; set; }
        public int PublicadorId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string Observacao { get; set; }

        public CartaoModelo Cartao { get; set; }
        public PublicadorModelo Publicador { get; set; }
    }
}
