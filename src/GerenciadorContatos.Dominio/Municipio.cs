using System.Collections.Generic;

namespace GerenciadorContatos.Dominio
{
    public class Municipio : EntidadeBase<Municipio, int>
    {
        private int _unidadeFederacaoId;
        public int UnidadeFederacaoId
        {
            get { return _unidadeFederacaoId; }
            set { SetField(ref _unidadeFederacaoId, value); }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { SetField(ref _nome, value); }
        }

        private UnidadeFederacao _unidadeFederacao;
        public UnidadeFederacao UnidadeFederacao
        {
            get { return _unidadeFederacao; }
            set { SetField(ref _unidadeFederacao, value); }
        }

        private List<Congregacao> _congregacoes;
        public List<Congregacao> Congregacoes
        {
            get { return _congregacoes; }
            set { SetField(ref _congregacoes, value); }
        }
    }
}
