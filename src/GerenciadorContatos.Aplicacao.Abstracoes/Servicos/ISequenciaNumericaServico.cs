using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using System.Threading.Tasks;

namespace GerenciadorContatos.Aplicacao.Abstracoes.Servicos
{
    public interface ISequenciaNumericaServico : IServico<SequenciaNumerica, int, SequenciaNumericaModelo>
    {
        Task GerarDadosAsync();
    }
}
