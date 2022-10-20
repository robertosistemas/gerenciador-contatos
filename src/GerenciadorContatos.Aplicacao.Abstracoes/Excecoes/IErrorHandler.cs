using System;

namespace GerenciadorContatos.Aplicacao.Abstracoes.Excecoes
{
    public interface IErrorHandler
    {
        void HandleError(Exception ex);
    }
}
