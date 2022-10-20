using System.Collections.Generic;

namespace GerenciadorContatos.Dominio
{
    public class Congregacao : EntidadeBase<Congregacao, int>
    {
        private int _municipioId;
        public int MunicipioId
        {
            get { return _municipioId; }
            set { SetField(ref _municipioId, value); }
        }

        private int _numero;
        public int Numero
        {
            get { return _numero; }
            set { SetField(ref _numero, value); }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { SetField(ref _nome, value); }
        }

        private Municipio _municipio;
        public Municipio Municipio
        {
            get { return _municipio; }
            set { SetField(ref _municipio, value); }
        }

        private List<Publicador> _publicadores;
        public List<Publicador> Publicadores
        {
            get { return _publicadores; }
            set { SetField(ref _publicadores, value); }
        }

        private List<Cartao> _cartoes;
        public List<Cartao> Cartoes
        {
            get { return _cartoes; }
            set { SetField(ref _cartoes, value); }
        }

        private List<SequenciaNumerica> _sequenciasNumericas;
        public List<SequenciaNumerica> SequenciasNumericas
        {
            get { return _sequenciasNumericas; }
            set { SetField(ref _sequenciasNumericas, value); }
        }
    }
}
