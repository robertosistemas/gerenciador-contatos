using GerenciadorContatos.Aplicacao;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Dominio;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciadorContatos.Tests
{
    public class DatabaseTesteBase
    {
        protected ISimNaoServico SimNaoServico { get; private set; }
        protected IUnidadeFederacaoServico UnidadeFederacaoServico { get; private set; }
        protected IMunicipioServico MunicipioServico { get; private set; }
        protected ICongregacaoServico CongregacaoServico { get; private set; }
        protected IPublicadorServico PublicadorServico { get; private set; }
        protected IOperadoraServico OperadoraServico { get; private set; }
        protected ISequenciaNumericaServico SequenciaNumericaServico { get; private set; }
        protected ICartaoServico CartaoServico { get; private set; }
        protected ICartaoHistoricoServico CartaoHistoricoServico { get; private set; }
        protected IContatoServico ContatoServico { get; private set; }
        protected IContatoHistoricoServico ContatoHistoricoServico { get; private set; }

        public DatabaseTesteBase()
        {
            SimNaoServico = InjecaoDependencia.GetService<ISimNaoServico>();
            UnidadeFederacaoServico = InjecaoDependencia.GetService<IUnidadeFederacaoServico>();
            MunicipioServico = InjecaoDependencia.GetService<IMunicipioServico>();
            CongregacaoServico = InjecaoDependencia.GetService<ICongregacaoServico>();
            PublicadorServico = InjecaoDependencia.GetService<IPublicadorServico>();
            OperadoraServico = InjecaoDependencia.GetService<IOperadoraServico>();
            SequenciaNumericaServico = InjecaoDependencia.GetService<ISequenciaNumericaServico>();
            CartaoServico = InjecaoDependencia.GetService<ICartaoServico>();
            CartaoHistoricoServico = InjecaoDependencia.GetService<ICartaoHistoricoServico>();
            ContatoServico = InjecaoDependencia.GetService<IContatoServico>();
            ContatoHistoricoServico = InjecaoDependencia.GetService<IContatoHistoricoServico>();
        }

        private static readonly SemaphoreSlim ObtemIdSyncLock = new SemaphoreSlim(1, 1);

        protected static int ObtemId()
        {
            ObtemIdSyncLock.Wait();
            try
            {
                return GeradorSequencia.ObtemId();
            }
            finally
            {
                ObtemIdSyncLock.Release();
            }
        }

        protected async Task<SimNao> InserirSimNao(SimNao simNao)
        {
            simNao.Id = await SimNaoServico.InserirAsync(simNao);
            return simNao;
        }

        protected async Task<UnidadeFederacao> InserirUnidadeFederacao(UnidadeFederacao unidadeFederacao)
        {
            unidadeFederacao.Id = await UnidadeFederacaoServico.InserirAsync(unidadeFederacao);
            return unidadeFederacao;
        }

        protected async Task<Municipio> InserirMunicipio(Municipio municipio)
        {
            municipio.Id = await MunicipioServico.InserirAsync(municipio);
            return municipio;
        }

        protected async Task<Congregacao> InserirCongregacao(Congregacao congregacao)
        {
            congregacao.Id = await CongregacaoServico.InserirAsync(congregacao);
            return congregacao;
        }
        protected async Task<Publicador> InserirPublicador(Publicador publicador)
        {
            publicador.Id = await PublicadorServico.InserirAsync(publicador);
            return publicador;
        }

        protected async Task<Operadora> InserirOperadora(Operadora operadora)
        {
            operadora.Id = await OperadoraServico.InserirAsync(operadora);
            return operadora;
        }

        protected async Task<SequenciaNumerica> InserirSequenciaNumerica(SequenciaNumerica sequenciaNumerica)
        {
            sequenciaNumerica.Id = await SequenciaNumericaServico.InserirAsync(sequenciaNumerica);
            return sequenciaNumerica;
        }

        protected async Task<Cartao> InserirCartao(Cartao cartao)
        {
            cartao.Id = await CartaoServico.InserirAsync(cartao);
            return cartao;
        }

        protected async Task<CartaoHistorico> InserirCartaoHistorico(CartaoHistorico cartaoHistorico)
        {
            cartaoHistorico.Id = await CartaoHistoricoServico.InserirAsync(cartaoHistorico);
            return cartaoHistorico;
        }

        protected async Task<Contato> InserirContato(Contato contato)
        {
            contato.Id = await ContatoServico.InserirAsync(contato);
            return contato;
        }

        protected async Task<ContatoHistorico> InserirContatoHistorico(ContatoHistorico contatoHistorico)
        {
            contatoHistorico.Id = await ContatoHistoricoServico.InserirAsync(contatoHistorico);
            return contatoHistorico;
        }

        private static readonly SemaphoreSlim CriarUnidadeFederacaoSyncLock = new SemaphoreSlim(1, 1);

        protected async Task<UnidadeFederacao> CriarUnidadeFederacaoAsync()
        {
            await CriarUnidadeFederacaoSyncLock.WaitAsync();
            UnidadeFederacao unidadeFederacao;
            try
            {
                var estados = await UnidadeFederacaoServico.ObterAsync(f => f.Sigla == "SC");
                if (estados.Dados.Count == 0)
                {
                    var unidadeFederacaoId = await UnidadeFederacaoServico.InserirAsync(new UnidadeFederacao { Sigla = "SC", Nome = $"Santa Catarina-{System.Guid.NewGuid()}" });
                    unidadeFederacao = await UnidadeFederacaoServico.ObterPorIdAsync(unidadeFederacaoId);
                }
                else
                    unidadeFederacao = estados.Dados.First();
                return unidadeFederacao;
            }
            finally
            {
                CriarUnidadeFederacaoSyncLock.Release();
            }
        }

        private static readonly SemaphoreSlim CriarMunicipioSyncLock = new SemaphoreSlim(1, 1);

        protected async Task<Municipio> CriarMunicipioAsync()
        {
            await CriarMunicipioSyncLock.WaitAsync();
            Municipio municipio;
            try
            {
                var municipios = await MunicipioServico.ObterAsync(f => f.Nome.StartsWith("Florianópolis"));
                if (municipios.Dados.Count == 0)
                {
                    UnidadeFederacao unidadeFederacao = await CriarUnidadeFederacaoAsync();
                    var municipioId = await MunicipioServico.InserirAsync(new Municipio { UnidadeFederacaoId = unidadeFederacao.Id, Nome = $"Florianópolis-{System.Guid.NewGuid()}" });
                    municipio = await MunicipioServico.ObterPorIdAsync(municipioId);
                }
                else
                    municipio = municipios.Dados.First();
                return municipio;
            }
            finally
            {
                CriarMunicipioSyncLock.Release();
            }
        }

        private static readonly SemaphoreSlim CriarCongregacaoSyncLock = new SemaphoreSlim(1, 1);

        protected async Task<Congregacao> CriarCongregacaoAsync()
        {
            await CriarCongregacaoSyncLock.WaitAsync();
            Congregacao congregacao;
            try
            {
                var congregacoes = await CongregacaoServico.ObterAsync(f => f.Nome.StartsWith("Cachoeira"));
                if (congregacoes.Dados.Count == 0)
                {
                    Municipio municipio = await CriarMunicipioAsync();
                    var congregacaoId = await CongregacaoServico.InserirAsync(new Congregacao { MunicipioId = municipio.Id, Numero = ObtemId(), Nome = $"Cachoeira-{System.Guid.NewGuid()}" });
                    congregacao = await CongregacaoServico.ObterPorIdAsync(congregacaoId);
                }
                else
                    congregacao = congregacoes.Dados.First();
                return congregacao;
            }
            finally
            {
                CriarCongregacaoSyncLock.Release();
            }
        }

        private static readonly SemaphoreSlim CriarPublicadorSyncLock = new SemaphoreSlim(1, 1);

        protected async Task<Publicador> CriarPublicadorAsync()
        {
            await CriarPublicadorSyncLock.WaitAsync();
            Publicador publicador;
            try
            {
                var publicadores = await PublicadorServico.ObterAsync(f => f.Nome.StartsWith("José da Silva"));
                if (publicadores.Dados.Count == 0)
                {
                    Congregacao congregacao = await CriarCongregacaoAsync();
                    var publicadorId = await PublicadorServico.InserirAsync(new Publicador { CongregacaoId = congregacao.Id, Nome = $"José da Silva-{System.Guid.NewGuid()}" });
                    publicador = await PublicadorServico.ObterPorIdAsync(publicadorId);
                }
                else
                    publicador = publicadores.Dados.First();
                return publicador;
            }
            finally
            {
                CriarPublicadorSyncLock.Release();
            }
        }

    }
}
