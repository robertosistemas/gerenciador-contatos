using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;

namespace GerenciadorContatos.Aplicacao.Abstracoes.Servicos
{
    public interface IContatoServico : IServico<Contato, int, ContatoModelo>
    {
    }
}
