using AutoMapper;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorContatos.Aplicacao.Servicos
{
    public class SequenciaNumericaServico : Servico<SequenciaNumerica, int, SequenciaNumericaModelo>, ISequenciaNumericaServico
    {
        private readonly IMapper _mapper;
        private readonly InformacaoPagina _informacaoPagina;
        private readonly IOperadoraServico _operadoraServico;
        private readonly IUnidadeDeTrabalho _unidadeDeTrabalho;

        public SequenciaNumericaServico(IMapper mapper,
            ISequenciaNumericaRepositorio sequenciaNumericaRepositorio,
            InformacaoPagina informacaoPagina,
            IOperadoraServico operadoraServico,
            IUnidadeDeTrabalho unidadeDeTrabalho) : base(mapper, sequenciaNumericaRepositorio)
        {
            _mapper = mapper;
            _informacaoPagina = informacaoPagina;
            _operadoraServico = operadoraServico;
            _unidadeDeTrabalho = unidadeDeTrabalho;
        }

        public async Task GerarDadosAsync()
        {
            _informacaoPagina.Tamanho = int.MaxValue - 1;

            var sequenciaNumericaContainerDados = await ObterAsync(informacaoPagina: _informacaoPagina);

            var sequencias = sequenciaNumericaContainerDados.Dados
                .OrderBy(f => f.CongregacaoId)
                .ThenBy(f => f.OperadoraId)
                .ThenBy(f => f.PreFixo)
                .ThenBy(f => f.Inicio).ToList();

            var numeroCartao = 0;

            foreach (var sequencia in sequencias)
            {
                var operadora = await _operadoraServico.ObterPorIdAsync(sequencia.OperadoraId);
                var quantidadeTelefonePorCartao = sequencia.QuantidadeTelefonesCartao;
                var contaFaixaFinal = 0;
                var contaContatos = 0;
                var contatosInserir = new List<Contato>();
                var cartaoId = 0;

                _unidadeDeTrabalho.IniciaTransacao();
                try
                {

                    for (var contador = sequencia.Inicio; contador <= sequencia.Fim; contador++)
                    {

                        if ((numeroCartao == 0) || (contaContatos % quantidadeTelefonePorCartao == 0))
                        {
                            numeroCartao += 1;
                            contaFaixaFinal += 1;

                            var preFixoFormatado = sequencia.PreFixo.PadLeft(5, '0');

                            var faixaInicio = sequencia.Inicio + ((contaFaixaFinal - 1) * quantidadeTelefonePorCartao);
                            var faixaFinal = sequencia.Inicio + (contaFaixaFinal * quantidadeTelefonePorCartao) - 1;

                            var faixaInicioFormatado = faixaInicio.ToString().PadLeft(4, '0');
                            var faixaFinalFormatado = faixaFinal.ToString().PadLeft(4, '0');

                            var cartao = new Cartao
                            {
                                CongregacaoId = sequencia.CongregacaoId,
                                OperadoraId = sequencia.OperadoraId,
                                Numero = numeroCartao.ToString(),
                                FaixaNumerica = $"({preFixoFormatado}-{faixaInicioFormatado} até {preFixoFormatado}-{faixaFinalFormatado})",
                                Disponivel = true
                            };
                            var cartaoModelo = _mapper.Map<CartaoModelo>(cartao);
                            cartaoId = await _unidadeDeTrabalho.CartaoRepositorio.InserirAsync(cartaoModelo);
                        }

                        var numeroPreFixoFormatado = sequencia.PreFixo.PadLeft(5, '0');
                        var numeroContato = sequencia.Inicio + contaContatos;
                        var numeroContatoFormatado = numeroContato.ToString().PadLeft(4, '0');
                        var codigoOperadoraFormatado = operadora.Codigo.ToString().PadLeft(3, '0');
                        var codigoAreaFormatado = sequencia.CodigoArea.PadLeft(3, '0');
                        var contato = new Contato
                        {
                            OperadoraId = sequencia.OperadoraId,
                            CartaoId = cartaoId,
                            Numero = $"({codigoAreaFormatado}){numeroPreFixoFormatado}-{numeroContatoFormatado}",
                            PermiteLigar = true
                        };
                        contatosInserir.Add(contato);

                        contaContatos += 1;

                        if (contaContatos % quantidadeTelefonePorCartao == 0)
                        {
                            var contatosModelo = _mapper.Map<List<ContatoModelo>>(contatosInserir);
                            await _unidadeDeTrabalho.ContatoRepositorio.InserirAsync(contatosModelo);
                            await _unidadeDeTrabalho.SalvarAsync();

                            _unidadeDeTrabalho.ConfirmaTransacao();
                            _unidadeDeTrabalho.IniciaTransacao();

                            contatosInserir = new List<Contato>();
                        }
                    }

                    if (contatosInserir.Count > 0)
                    {
                        var contatosModelo = _mapper.Map<List<ContatoModelo>>(contatosInserir);
                        await _unidadeDeTrabalho.ContatoRepositorio.InserirAsync(contatosModelo);
                    }

                    await _unidadeDeTrabalho.SalvarAsync();
                    _unidadeDeTrabalho.ConfirmaTransacao();

                }
                catch (System.Exception)
                {
                    _unidadeDeTrabalho.CancelaTransacao();
                    throw;
                }
            }
        }
    }
}
