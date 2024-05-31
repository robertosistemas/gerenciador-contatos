using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GerenciadorContatos.Repositorio.Abstracoes
{
    public interface IRepositorio<TModel, TKey> where TModel : ModeloBase<TKey>
    {
        Task<TKey> InserirAsync(TModel entity);
        Task InserirAsync(List<TModel> entities);
        Task AtualizarAsync(TModel entityToUpdate);
        Task ExcluirAsync(TKey id);
        Task ExcluirAsync(TModel entityToDelete);
        Task<TModel> ObterPorIdAsync(object id);
        Task<ContainerDados<List<TModel>>> ObterAsync(Expression<Func<TModel, bool>> filter = null,
            string orderBy = "",
            string includeProperties = "", InformacaoPagina informacaoPagina = null);
        Task<bool> ExisteAsync(Expression<Func<TModel, bool>> filter);
    }
}
