using System.Collections.Generic;

namespace GerenciadorContatos.Dominio
{
    public class Publicador : EntidadeBase<Publicador, int>
    {
        private int _congregacaoId;
        public int CongregacaoId
        {
            get { return _congregacaoId; }
            set { SetField(ref _congregacaoId, value); }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { SetField(ref _nome, value); }
        }

        private Congregacao _congregacao;
        public Congregacao Congregacao
        {
            get { return _congregacao; }
            set { SetField(ref _congregacao, value); }
        }

        private List<CartaoHistorico> _cartoesHistoricos;
        public List<CartaoHistorico> CartoesHistoricos
        {
            get { return _cartoesHistoricos; }
            set { SetField(ref _cartoesHistoricos, value); }
        }

        private List<ContatoHistorico> _contatosHistoricos;
        public List<ContatoHistorico> ContatosHistoricos
        {
            get { return _contatosHistoricos; }
            set { SetField(ref _contatosHistoricos, value); }
        }

        private List<Cartao> _cartoes;
        public List<Cartao> Cartoes
        {
            get { return _cartoes; }
            set { SetField(ref _cartoes, value); }
        }
    }
}
