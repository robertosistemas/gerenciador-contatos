using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GerenciadorContatos.Repositorio
{
    public class Repositorio<TModel, TKey> : IRepositorio<TModel, TKey> where TModel : ModeloBase<TKey>
    {
        protected readonly GerenciadorContatoDbContext _gerenciadorContatoDbContext;
        protected readonly DbSet<TModel> _dbSet;

        public Repositorio(GerenciadorContatoDbContext gerenciadorContatoDbContext)
        {
            _gerenciadorContatoDbContext = gerenciadorContatoDbContext;
            _dbSet = _gerenciadorContatoDbContext.Set<TModel>();
        }

        public virtual async Task InserirAsync(List<TModel> entities)
        {
            _dbSet.AddRange(entities);
            await _gerenciadorContatoDbContext.SaveChangesAsync();
        }

        public virtual async Task<TKey> InserirAsync(TModel entity)
        {
            _dbSet.Add(entity);
            await _gerenciadorContatoDbContext.SaveChangesAsync();
            return entity.Id;
        }

        public virtual async Task AtualizarAsync(TModel entityToUpdate)
        {
            TModel entityExiste = await _dbSet.FindAsync(entityToUpdate.Id);
            if (entityExiste != null)
            {
                _gerenciadorContatoDbContext.Entry(entityExiste).CurrentValues.SetValues(entityToUpdate);
                await _gerenciadorContatoDbContext.SaveChangesAsync();
            }
        }

        public virtual async Task ExcluirAsync(TKey id)
        {
            TModel entityToDelete = await _dbSet.FindAsync(id);
            if (entityToDelete != null)
                await ExcluirAsync(entityToDelete);
        }

        public virtual async Task ExcluirAsync(TModel entityToDelete)
        {
            var entityToFind = (ModeloBase<TKey>)entityToDelete;
            TModel entityExiste = await _dbSet.FindAsync(entityToFind.Id);
            if (entityExiste != null)
            {
                try
                {
                    _dbSet.Remove(entityExiste);
                    await _gerenciadorContatoDbContext.SaveChangesAsync();
                }
                catch
                {
                    _gerenciadorContatoDbContext.Entry(entityExiste).State = EntityState.Unchanged;
                    throw;
                }
            }
        }

        public virtual async Task<TModel> ObterPorIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<ContainerDados<List<TModel>>> ObterAsync(
            Expression<Func<TModel, bool>> filter = null,
            string orderBy = "",
            string includeProperties = "", InformacaoPagina informacaoPagina = null)
        {
            var infoPagina = informacaoPagina ?? new InformacaoPagina();
            if (infoPagina.Indice < 1)          
                infoPagina.Indice = 1;

            IQueryable<TModel> query = _dbSet.AsNoTracking();

            if (filter != null && !filter.ToString().Equals(PredicateBuilder.New<TModel>(true).ToString()))
                query = query.Where(filter);

            if (!string.IsNullOrWhiteSpace(includeProperties))
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    query = query.Include(includeProperty.Trim());

            if (string.IsNullOrWhiteSpace(orderBy))
                query = query.OrderBy(f => f.Id);
            else
                query = query.OrderBy(orderBy);

            var skip = (infoPagina.Indice - 1) * infoPagina.Tamanho;
            var take = infoPagina.Tamanho + 1;

            query = query.Skip(skip).Take(take);

            var itens = await query.ToListAsync();

            infoPagina.TemMaisPaginas = itens.Count > infoPagina.Tamanho;

            return new ContainerDados<List<TModel>>(infoPagina, itens.Take(infoPagina.Tamanho).ToList());
        }

        public virtual async Task<bool> ExisteAsync(Expression<Func<TModel, bool>> filter)
        {
            IQueryable<TModel> query = _dbSet.AsNoTracking();
            query = query.Where(filter);
            var model = await query.FirstOrDefaultAsync();
            return model != null;
        }
    }
}