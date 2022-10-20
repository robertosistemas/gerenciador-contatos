using System.Collections.Generic;

namespace GerenciadorContatos.Dominio
{
    public class Contato : EntidadeBase<Contato, int>
    {
        private int _operadoraId;
        public int OperadoraId
        {
            get { return _operadoraId; }
            set { SetField(ref _operadoraId, value); }
        }

        private int _cartaoId;
        public int CartaoId
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

        private bool _permiteLigar;
        public bool PermiteLigar
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

        private Operadora _operadora;
        public Operadora Operadora
        {
            get { return _operadora; }
            set { SetField(ref _operadora, value); }
        }

        private Cartao _cartao;
        public Cartao Cartao
        {
            get { return _cartao; }
            set { SetField(ref _cartao, value); }
        }


        private List<ContatoHistorico> _contatosHistoricos;
        public List<ContatoHistorico> ContatosHistoricos
        {
            get { return _contatosHistoricos; }
            set { SetField(ref _contatosHistoricos, value); }
        }
    }
}
