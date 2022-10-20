using GerenciadorContatos.Aplicacao.Abstracoes.Excecoes;
using System;
using System.Threading.Tasks;

namespace GerenciadorContatos.Aplicacao.Excecoes
{
    public static class TaskUtilities
    {
#pragma warning disable RECS0165 // Asynchronous methods should return a Task instead of void
        public static async void FireAndForgetSafeAsync(this Task task, IErrorHandler handler = null)
#pragma warning restore RECS0165 // Asynchronous methods should return a Task instead of void
        {
            try
            {
                await task;
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception ex)
            {
                handler?.HandleError(ex);
            }
#pragma warning restore CA1031 // Do not catch general exception types
        }
    }
}
