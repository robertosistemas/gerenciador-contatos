using GerenciadorContatos.Dominio.Abstracoes;

namespace GerenciadorContatos.Modelos
{
    public class ModeloBase<TKey> : IEntidade<TKey>
    {
        public virtual TKey Id { get; set; }
    }
}
