using System.Collections.Generic;

namespace GerenciadorContatos.Modelos
{
    public class MunicipioModelo : ModeloBase<int>
    {
        public int UnidadeFederacaoId { get; set; }
        public string Nome { get; set; }

        public UnidadeFederacaoModelo UnidadeFederacao { get; set; }
        public List<CongregacaoModelo> Congregacoes { get; set; }
    }
}
