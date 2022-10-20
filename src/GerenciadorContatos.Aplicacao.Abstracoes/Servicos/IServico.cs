using GerenciadorContatos.Dominio;
using GerenciadorContatos.Dominio.Abstracoes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GerenciadorContatos.Aplicacao.Abstracoes.Servicos
{
    public interface IServico<TEntity, TKey, TModel>
        where TEntity : IEntidade<TKey>
        where TModel : IEntidade<TKey>
    {
        Task<TKey> InserirAsync(TEntity entity);
        Task InserirAsync(List<TEntity> entities);
        Task AtualizarAsync(TEntity entityToUpdate);
        Task ExcluirAsync(TKey id);
        Task ExcluirAsync(TEntity entityToDelete);
        Task<TEntity> ObterPorIdAsync(TKey id);
        Task<ContainerDados<List<TEntity>>> ObterAsync(Expression<Func<TEntity, bool>> filter = null,
            string orderBy = "",
            string includeProperties = "", InformacaoPagina informacaoPagina = null);
        Task<bool> ExisteAsync(Expression<Func<TEntity, bool>> filter);
    }
}
