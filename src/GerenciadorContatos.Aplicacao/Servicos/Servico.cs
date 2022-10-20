using AutoMapper;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Aplicacao.Excecoes;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GerenciadorContatos.Aplicacao.Servicos
{
    public class Servico<TEntity, TKey, TModel> : IServico<TEntity, TKey, TModel>
        where TEntity : EntidadeBase<TEntity, TKey>
        where TModel : ModeloBase<TKey>
    {

        private readonly IMapper _mapper;
        private readonly IRepositorio<TModel, TKey> _repositorio;

        public Servico(IMapper mapper, IRepositorio<TModel, TKey> repositorio)
        {
            _mapper = mapper;
            _repositorio = repositorio;
        }

        public async Task<TKey> InserirAsync(TEntity entity)
        {
            try
            {
                var item = _mapper.Map<TModel>(entity);
                return await _repositorio.InserirAsync(item);
            }
            catch (Exception ex)
            {
                throw new GerenciadorContatosException("Erro ao tentar inserir o registro", ex);
            }
        }

        public async Task InserirAsync(List<TEntity> entities)
        {
            try
            {
                var itens = _mapper.Map<List<TModel>>(entities);
                await _repositorio.InserirAsync(itens);
            }
            catch (Exception ex)
            {
                throw new GerenciadorContatosException("Erro ao tentar inserir os registros", ex);
            }
        }

        public virtual async Task AtualizarAsync(TEntity entityToUpdate)
        {
            try
            {
                var item = _mapper.Map<TModel>(entityToUpdate);
                await _repositorio.AtualizarAsync(item);
            }
            catch (Exception ex)
            {
                throw new GerenciadorContatosException("Erro ao tentar atualizar o registro", ex);
            }
        }

        public virtual async Task ExcluirAsync(TKey id)
        {
            await _repositorio.ExcluirAsync(id);
        }

        public virtual async Task ExcluirAsync(TEntity entityToDelete)
        {
            try
            {
                var item = _mapper.Map<TModel>(entityToDelete);
                await _repositorio.ExcluirAsync(item);
            }
            catch (Exception ex)
            {
                throw new GerenciadorContatosException("Erro ao tentar excluir o registro", ex);
            }
        }

        public virtual async Task<TEntity> ObterPorIdAsync(TKey id)
        {
            var item = await _repositorio.ObterPorIdAsync(id);
            return _mapper.Map<TEntity>(item);
        }

        public virtual async Task<ContainerDados<List<TEntity>>> ObterAsync(
            Expression<Func<TEntity, bool>> filter = null,
            string orderBy = "",
            string includeProperties = "", InformacaoPagina informacaoPagina = null)
        {
            var filtro = _mapper.Map<Expression<Func<TModel, bool>>>(filter);
            var itens = await _repositorio.ObterAsync(filtro, orderBy, includeProperties, informacaoPagina);
            return _mapper.Map<ContainerDados<List<TEntity>>>(itens);
        }

        public virtual async Task<bool> ExisteAsync(Expression<Func<TEntity, bool>> filter)
        {
            var filtro = _mapper.Map<Expression<Func<TModel, bool>>>(filter);
            return await _repositorio.ExisteAsync(filtro);
        }
    }
}