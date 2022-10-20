using System.Collections.Generic;

namespace GerenciadorContatos.Dominio
{
    public class UnidadeFederacao : EntidadeBase<UnidadeFederacao, int>
    {
        private string _sigla;
        public string Sigla
        {
            get { return _sigla; }
            set { SetField(ref _sigla, value); }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { SetField(ref _nome, value); }
        }

        private List<Municipio> _municipios;
        public List<Municipio> Municipios
        {
            get { return _municipios; }
            set { SetField(ref _municipios, value); }
        }
    }
}
