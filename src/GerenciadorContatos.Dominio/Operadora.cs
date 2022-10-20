using System.Collections.Generic;

namespace GerenciadorContatos.Dominio
{
    public class Operadora : EntidadeBase<Operadora, int>
    {
        private int _codigo;
        public int Codigo
        {
            get { return _codigo; }
            set { SetField(ref _codigo, value); }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { SetField(ref _nome, value); }
        }

        private List<Cartao> _cartoes;
        public List<Cartao> Cartoes
        {
            get { return _cartoes; }
            set { SetField(ref _cartoes, value); }
        }

        private List<Contato> _contatos;
        public List<Contato> Contatos
        {
            get { return _contatos; }
            set { SetField(ref _contatos, value); }
        }

        private List<SequenciaNumerica> _sequenciasNumericas;
        public List<SequenciaNumerica> SequenciasNumericas
        {
            get { return _sequenciasNumericas; }
            set { SetField(ref _sequenciasNumericas, value); }
        }
    }
}
