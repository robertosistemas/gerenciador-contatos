using System;

namespace GerenciadorContatos.Dominio.Dtos
{
    public class CartaoFiltroDto : EntidadeBase<CartaoFiltroDto, int?>
    {
        private int? _congregacaoId;
        public int? CongregacaoId
        {
            get { return _congregacaoId; }
            set { SetField(ref _congregacaoId, value); }
        }

        private int? _operadoraId;
        public int? OperadoraId
        {
            get { return _operadoraId; }
            set { SetField(ref _operadoraId, value); }
        }

        private string _numero;
        public string Numero
        {
            get { return _numero; }
            set { SetField(ref _numero, value); }
        }

        private string _faixaNumerica;
        public string FaixaNumerica
        {
            get { return _faixaNumerica; }
            set { SetField(ref _faixaNumerica, value); }
        }

        private bool? _disponivel;
        public bool? Disponivel
        {
            get { return _disponivel; }
            set { SetField(ref _disponivel, value); }
        }

        private int? _publicadorId;
        public int? PublicadorId
        {
            get { return _publicadorId; }
            set { SetField(ref _publicadorId, value); }
        }

        private DateTime? _dataInicio;
        public DateTime? DataInicio
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
    }
}
