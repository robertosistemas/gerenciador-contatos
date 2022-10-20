using System.Threading;

namespace GerenciadorContatos.Tests
{
    public static class GeradorSequencia
    {
        private static int numeroSequencial = 0;
        public static int ObtemId()
        {
            return Interlocked.Increment(ref numeroSequencial);
        }
        public static readonly SemaphoreSlim SyncLock = new SemaphoreSlim(1, 1);
    }
}
