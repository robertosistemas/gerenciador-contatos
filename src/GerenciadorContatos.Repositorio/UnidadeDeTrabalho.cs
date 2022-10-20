using GerenciadorContatos.Repositorio.Abstracoes;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace GerenciadorContatos.Repositorio
{
    public class UnidadeDeTrabalho : IUnidadeDeTrabalho, IDisposable
    {
        private bool _emTransacao;
        private bool _completarTransacao;
        private DbContextTransaction _dbContextTransaction;

        private readonly GerenciadorContatoDbContext _gerenciadorContatoDbContext;
        private readonly ICartaoRepositorio _cartaoRepositorio;
        private readonly ICartaoHistoricoRepositorio _cartaoHistoricoRepositorio;
        private readonly ICongregacaoRepositorio _congregacaoRepositorio;
        private readonly IContatoRepositorio _contatoRepositorio;
        private readonly IContatoHistoricoRepositorio _contatoHistoricoRepositorio;
        private readonly IMunicipioRepositorio _municipioRepositorio;
        private readonly IOperadoraRepositorio _operadoraRepositorio;
        private readonly IPublicadorRepositorio _publicadorRepositorio;
        private readonly ISequenciaNumericaRepositorio _sequenciaNumericaRepositorio;
        private readonly IUnidadeFederacaoRepositorio _unidadeFederacaoRepositorio;
        private readonly ISimNaoRepositorio _simNaoRepositorio;

        public UnidadeDeTrabalho(GerenciadorContatoDbContext gerenciadorContatoDbContext)
        {
            _gerenciadorContatoDbContext = gerenciadorContatoDbContext;
            _cartaoRepositorio = new CartaoRepositorio(_gerenciadorContatoDbContext);
            _cartaoHistoricoRepositorio = new CartaoHistoricoRepositorio(_gerenciadorContatoDbContext);
            _congregacaoRepositorio = new CongregacaoRepositorio(_gerenciadorContatoDbContext);
            _contatoRepositorio = new ContatoRepositorio(_gerenciadorContatoDbContext);
            _contatoHistoricoRepositorio = new ContatoHistoricoRepositorio(_gerenciadorContatoDbContext);
            _municipioRepositorio = new MunicipioRepositorio(_gerenciadorContatoDbContext);
            _operadoraRepositorio = new OperadoraRepositorio(_gerenciadorContatoDbContext);
            _publicadorRepositorio = new PublicadorRepositorio(_gerenciadorContatoDbContext);
            _sequenciaNumericaRepositorio = new SequenciaNumericaRepositorio(_gerenciadorContatoDbContext);
            _unidadeFederacaoRepositorio = new UnidadeFederacaoRepositorio(_gerenciadorContatoDbContext);
            _simNaoRepositorio = new SimNaoRepositorio(_gerenciadorContatoDbContext);
        }

        public ICartaoRepositorio CartaoRepositorio
        {
            get { return _cartaoRepositorio; }
        }

        public ICartaoHistoricoRepositorio CartaoHistoricoRepositorio
        {
            get { return _cartaoHistoricoRepositorio; }
        }

        public ICongregacaoRepositorio CongregacaoRepositorio
        {
            get { return _congregacaoRepositorio; }
        }

        public IContatoRepositorio ContatoRepositorio
        {
            get { return _contatoRepositorio; }
        }

        public IContatoHistoricoRepositorio ContatoHistoricoRepositorio
        {
            get { return _contatoHistoricoRepositorio; }
        }

        public IMunicipioRepositorio MunicipioRepositorio
        {
            get { return _municipioRepositorio; }
        }

        public IOperadoraRepositorio OperadoraRepositorio
        {
            get { return _operadoraRepositorio; }
        }

        public IPublicadorRepositorio PublicadorRepositorio
        {
            get { return _publicadorRepositorio; }
        }

        public ISequenciaNumericaRepositorio SequenciaNumericaRepositorio
        {
            get { return _sequenciaNumericaRepositorio; }
        }

        public IUnidadeFederacaoRepositorio UnidadeFederacaoRepositorio
        {
            get { return _unidadeFederacaoRepositorio; }
        }

        public ISimNaoRepositorio SimNaoRepositorio
        {
            get { return _simNaoRepositorio; }
        }

        public void IniciaTransacao()
        {
            if (!_emTransacao)
            {
                _dbContextTransaction = _gerenciadorContatoDbContext.Database.BeginTransaction();
                _emTransacao = true;
                _completarTransacao = false;
            }
        }

        public void ConfirmaTransacao()
        {
            if (_emTransacao && _dbContextTransaction != null)
            {
                _dbContextTransaction.Commit();
                _dbContextTransaction.Dispose();
                _dbContextTransaction = null;
            }
            _emTransacao = false;
            _completarTransacao = false;
        }

        public void CancelaTransacao()
        {
            if (_emTransacao && _dbContextTransaction != null)
            {
                _dbContextTransaction.Rollback();
                _dbContextTransaction.Dispose();
                _dbContextTransaction = null;
            }
            _emTransacao = false;
            _completarTransacao = false;
        }
        public void CompletarTransacao()
        {
            _completarTransacao = _emTransacao;
        }

        public async Task SalvarAsync()
        {
            await _gerenciadorContatoDbContext.SaveChangesAsync();
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    if (_emTransacao && _dbContextTransaction != null)
                    {
                        if (_completarTransacao)
                            ConfirmaTransacao();
                        else
                            CancelaTransacao();
                    }
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnitOfWork()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
