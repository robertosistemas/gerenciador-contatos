namespace GerenciadorContatos.Dominio.Abstracoes
{
    public interface IEntidade<TKey>
    {
        TKey Id { get; set; }
    }
}
