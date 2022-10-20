using System.Collections.Generic;

namespace GerenciadorContatos.Modelos
{
    public class CongregacaoModelo : ModeloBase<int>
    {
        public int MunicipioId { get; set; }
        public int Numero { get; set; }
        public string Nome { get; set; }

        public MunicipioModelo Municipio { get; set; }
        public List<PublicadorModelo> Publicadores { get; set; }
        public List<CartaoModelo> Cartoes { get; set; }
        public List<SequenciaNumericaModelo> SequenciasNumericas { get; set; }
    }
}
