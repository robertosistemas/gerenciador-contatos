namespace GerenciadorContatos.Dominio
{
    public class ContainerDados<T>
    {
        public ContainerDados(InformacaoPagina informacaoPagina, T dados)
        {
            InformacaoPagina = informacaoPagina;
            Dados = dados;
        }

        public InformacaoPagina InformacaoPagina { get; private set; }
        public T Dados { get; private set; }
    }
}
