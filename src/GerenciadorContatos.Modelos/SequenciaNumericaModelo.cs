namespace GerenciadorContatos.Modelos
{
    public class SequenciaNumericaModelo : ModeloBase<int>
    {
        public int CongregacaoId { get; set; }
        public int OperadoraId { get; set; }
        public string CodigoArea { get; set; }
        public string PreFixo { get; set; }
        public int Inicio { get; set; }
        public int Fim { get; set; }
        public int QuantidadeTelefonesCartao { get; set; }

        public CongregacaoModelo Congregacao { get; set; }
        public OperadoraModelo Operadora { get; set; }

    }
}
