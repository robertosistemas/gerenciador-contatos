using System;

namespace GerenciadorContatos.Dominio
{
    public class ContatoHistorico : EntidadeBase<ContatoHistorico, int>
    {
        private int _contatoId;
        public int ContatoId
        {
            get { return _contatoId; }
            set { SetField(ref _contatoId, value); }
        }

        private int _publicadorId;
        public int PublicadorId
        {
            get { return _publicadorId; }
            set { SetField(ref _publicadorId, value); }
        }

        private DateTime _data;
        public DateTime Data
        {
            get { return _data; }
            set { SetField(ref _data, value); }
        }

        private string _observacao;
        public string Observacao
        {
            get { return _observacao; }
            set { SetField(ref _observacao, value); }
        }

        private Contato _contato;
        public Contato Contato
        {
            get { return _contato; }
            set { SetField(ref _contato, value); }
        }

        private Publicador _publicador;
        public Publicador Publicador
        {
            get { return _publicador; }
            set { SetField(ref _publicador, value); }
        }
    }
}
