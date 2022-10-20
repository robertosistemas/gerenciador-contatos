using GerenciadorContatos.Aplicacao.Abstracoes.Excecoes;
using System;
using System.Text;
using System.Windows.Forms;

namespace GerenciadorContatos.Excecoes
{
    public class FormErrorHandler : IErrorHandler
    {
        public void HandleError(Exception ex)
        {
            var mensagens = new StringBuilder();
            mensagens.AppendLine(ex.Message);
            var innerException = ex.InnerException;
            while (innerException != null)
            {
                mensagens.AppendLine(innerException.Message);
                innerException = innerException.InnerException;
            }
            MessageBox.Show(mensagens.ToString(), "Gerenciador contatos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}