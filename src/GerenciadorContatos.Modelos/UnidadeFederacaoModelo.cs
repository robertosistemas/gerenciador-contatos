using System.Collections.Generic;

namespace GerenciadorContatos.Modelos
{
    public class UnidadeFederacaoModelo : ModeloBase<int>
    {
        public string Sigla { get; set; }
        public string Nome { get; set; }

        public List<MunicipioModelo> Municipios { get; set; }
    }
}
