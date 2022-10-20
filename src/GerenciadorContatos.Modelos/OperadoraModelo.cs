using System.Collections.Generic;

namespace GerenciadorContatos.Modelos
{
    public class OperadoraModelo : ModeloBase<int>
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public List<CartaoModelo> Cartoes { get; set; }
        public List<ContatoModelo> Contatos { get; set; }
        public List<SequenciaNumericaModelo> SequenciasNumericas { get; set; }
    }
}
