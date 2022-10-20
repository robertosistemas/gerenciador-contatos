using System;
using System.Collections.Generic;

namespace GerenciadorContatos.Modelos
{
    public class CartaoModelo : ModeloBase<int>
    {
        public int CongregacaoId { get; set; }
        public int OperadoraId { get; set; }
        public string Numero { get; set; }
        public string FaixaNumerica { get; set; }
        public bool Disponivel { get; set; }
        public int? PublicadorId { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string Observacao { get; set; }

        public CongregacaoModelo Congregacao { get; set; }
        public OperadoraModelo Operadora { get; set; }
        public PublicadorModelo Publicador { get; set; }
        public List<CartaoHistoricoModelo> CartoesHistoricos { get; set; }
        public List<ContatoModelo> Contatos { get; set; }
    }
}
