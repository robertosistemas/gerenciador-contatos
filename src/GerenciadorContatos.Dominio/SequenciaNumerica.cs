namespace GerenciadorContatos.Dominio
{
    public class SequenciaNumerica : EntidadeBase<SequenciaNumerica, int>
    {
        private int _congregacaoId;
        public int CongregacaoId
        {
            get { return _congregacaoId; }
            set { SetField(ref _congregacaoId, value); }
        }

        private int _operadoraId;
        public int OperadoraId
        {
            get { return _operadoraId; }
            set { SetField(ref _operadoraId, value); }
        }

        private string _codigoArea;
        public string CodigoArea
        {
            get { return _codigoArea; }
            set { SetField(ref _codigoArea, value); }
        }

        private string _preFixo;
        public string PreFixo
        {
            get { return _preFixo; }
            set { SetField(ref _preFixo, value); }
        }

        private int _inicio;
        public int Inicio
        {
            get { return _inicio; }
            set { SetField(ref _inicio, value); }
        }

        private int _fim;
        public int Fim
        {
            get { return _fim; }
            set { SetField(ref _fim, value); }
        }

        private int _quantidadeTelefonesCartao;
        public int QuantidadeTelefonesCartao
        {
            get { return _quantidadeTelefonesCartao; }
            set { SetField(ref _quantidadeTelefonesCartao, value); }
        }

        private Congregacao _congregacao;
        public Congregacao Congregacao
        {
            get { return _congregacao; }
            set { SetField(ref _congregacao, value); }
        }

        private Operadora _operadora;
        public Operadora Operadora
        {
            get { return _operadora; }
            set { SetField(ref _operadora, value); }
        }
    }
}
