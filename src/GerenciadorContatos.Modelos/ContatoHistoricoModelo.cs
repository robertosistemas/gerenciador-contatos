using System;

namespace GerenciadorContatos.Modelos
{
    public class ContatoHistoricoModelo : ModeloBase<int>
    {
        public int ContatoId { get; set; }
        public int PublicadorId { get; set; }
        public DateTime Data { get; set; }
        public string Observacao { get; set; }

        public ContatoModelo Contato { get; set; }
        public PublicadorModelo Publicador { get; set; }

    }
}
