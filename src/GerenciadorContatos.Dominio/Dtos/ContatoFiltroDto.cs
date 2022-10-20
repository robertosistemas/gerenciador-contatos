namespace GerenciadorContatos.Dominio.Dtos
{
    public class ContatoFiltroDto : EntidadeBase<ContatoFiltroDto, int>
    {
        private int? _operadoraId;
        public int? OperadoraId
        {
            get { return _operadoraId; }
            set { SetField(ref _operadoraId, value); }
        }

        private int? _cartaoId;
        public int? CartaoId
        {
            get { return _cartaoId; }
            set { SetField(ref _cartaoId, value); }
        }

        private string _numero;
        public string Numero
        {
            get { return _numero; }
            set { SetField(ref _numero, value); }
        }

        private string _numeroCartao;
        public string NumeroCartao
        {
            get { return _numeroCartao; }
            set { SetField(ref _numeroCartao, value); }
        }

        private string _numeroTelefone;
        public string NumeroTelefone
        {
            get { return _numeroTelefone; }
            set { SetField(ref _numeroTelefone, value); }
        }

        private bool? _permiteLigar;
        public bool? PermiteLigar
        {
            get { return _permiteLigar; }
            set { SetField(ref _permiteLigar, value); }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { SetField(ref _nome, value); }
        }

        private string _observacao;
        public string Observacao
        {
            get { return _observacao; }
            set { SetField(ref _observacao, value); }
        }
    }
}