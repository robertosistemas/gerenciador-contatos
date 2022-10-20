using System;

namespace GerenciadorContatos.Dominio
{
    public class DisposableBase : IDisposable
    {
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    DisposeExplicit();
                }
                DisposeImplicit();
                disposedValue = true;
            }
        }

        ~DisposableBase()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void DisposeExplicit() { }
        protected virtual void DisposeImplicit() { }
    }
}
