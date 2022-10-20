using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GerenciadorContatos.Aplicacao.Abstracoes.Servicos
{

    public delegate void CartoesContadosEventHandler(object sender, CartaoEventArgs cartaoEventArgs);
    public delegate void CartaoProcessadoEventHandler(object sender, CartaoEventArgs cartaoEventArgs);
    public delegate void CartoesExportadosEventHandler(object sender, CartaoEventArgs cartaoEventArgs);

    public interface ICartaoServico : IServico<Cartao, int, CartaoModelo>
    {
        Task DesignarAsync(Cartao cartao);
        Task DevolverAsync(Cartao cartao);
        Task<string> GerarDadosCartaoAsync(Cartao cartao, bool comFormatacao, bool colocarTracos);
        Task ExportarCartoesAsync(Expression<Func<Cartao, bool>> filter, string orderBy, string arquivoDestino);

        event CartoesContadosEventHandler CartoesContadosEventHandler;
        event CartaoProcessadoEventHandler CartaoProcessadoEventHandler;
        event CartoesExportadosEventHandler CartoesExportadosEventHandler;
    }
}
