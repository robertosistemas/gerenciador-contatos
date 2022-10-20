using System;
namespace GerenciadorContatos.Aplicacao.Abstracoes.Servicos
{
    public class CartaoEventArgs : EventArgs
    {
        public int Quantidade { get; set; }
        public int ItemAtual { get; set; }
    }
}
