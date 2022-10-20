using System.Threading.Tasks;

namespace GerenciadorContatos.Repositorio.Abstracoes
{
    public interface IUnidadeDeTrabalho
    {
        ICartaoRepositorio CartaoRepositorio { get; }
        ICartaoHistoricoRepositorio CartaoHistoricoRepositorio { get; }
        ICongregacaoRepositorio CongregacaoRepositorio { get; }
        IContatoRepositorio ContatoRepositorio { get; }
        IContatoHistoricoRepositorio ContatoHistoricoRepositorio { get; }
        IMunicipioRepositorio MunicipioRepositorio { get; }
        IOperadoraRepositorio OperadoraRepositorio { get; }
        IPublicadorRepositorio PublicadorRepositorio { get; }
        ISequenciaNumericaRepositorio SequenciaNumericaRepositorio { get; }
        IUnidadeFederacaoRepositorio UnidadeFederacaoRepositorio { get; }
        ISimNaoRepositorio SimNaoRepositorio { get; }
        void IniciaTransacao();
        void ConfirmaTransacao();
        void CancelaTransacao();
        void CompletarTransacao();
        Task SalvarAsync();
    }
}
