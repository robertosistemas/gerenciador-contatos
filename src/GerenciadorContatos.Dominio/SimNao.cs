namespace GerenciadorContatos.Dominio
{
    public class SimNao : EntidadeBase<SimNao, int>
    {

        private string _texto;
        public string Texto
        {
            get { return _texto; }
            set { SetField(ref _texto, value); }
        }

        private bool? _valor;
        public bool? Valor
        {
            get { return _valor; }
            set { SetField(ref _valor, value); }
        }

    }
}
