using System;

namespace GerenciadorContatos.Dominio
{
    public class CartaoHistorico : EntidadeBase<CartaoHistorico, int>
    {
        private int _cartaoId;
        public int CartaoId
        {
            get { return _cartaoId; }
            set { SetField(ref _cartaoId, value); }
        }

        private int _publicadorId;
        public int PublicadorId
        {
            get { return _publicadorId; }
            set { SetField(ref _publicadorId, value); }
        }

        private DateTime _dataInicio;
        public DateTime DataInicio
        {
            get { return _dataInicio; }
            set { SetField(ref _dataInicio, value); }
        }

        private DateTime? _dataFim;
        public DateTime? DataFim
        {
            get { return _dataFim; }
            set { SetField(ref _dataFim, value); }
        }

        private string _observacao;
        public string Observacao
        {
            get { return _observacao; }
            set { SetField(ref _observacao, value); }
        }

        private Cartao _cartao;
        public Cartao Cartao
        {
            get { return _cartao; }
            set { SetField(ref _cartao, value); }
        }

        private Publicador _publicador;
        public Publicador Publicador
        {
            get { return _publicador; }
            set { SetField(ref _publicador, value); }
        }
    }
}
