using AutoMapper;
using GerenciadorContatos.Aplicacao.Abstracoes.Servicos;
using GerenciadorContatos.Dominio;
using GerenciadorContatos.Modelos;
using GerenciadorContatos.Repositorio.Abstracoes;
using NPOI.XWPF.UserModel;
using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorContatos.Aplicacao.Servicos
{
    public class CartaoServico : Servico<Cartao, int, CartaoModelo>, ICartaoServico
    {
        private readonly IMapper _mapper;
        private readonly InformacaoPagina _informacaoPagina;
        private readonly IOperadoraServico _operadoraServico;
        private readonly IContatoServico _contatoServico;
        private readonly ICartaoHistoricoServico _cartaoHistoricoServico;
        private readonly IUnidadeDeTrabalho _unidadeDeTrabalho;

        public CartaoServico(IMapper mapper, ICartaoRepositorio cartaoRepositorio,
            InformacaoPagina informacaoPagina,
            IOperadoraServico operadoraServico,
            IContatoServico contatoServico,
            ICartaoHistoricoServico cartaoHistoricoServico,
            IUnidadeDeTrabalho unidadeDeTrabalho) : base(mapper, cartaoRepositorio)
        {
            _mapper = mapper;
            _informacaoPagina = informacaoPagina;
            _informacaoPagina.Tamanho = int.MaxValue - 1;
            _operadoraServico = operadoraServico;
            _contatoServico = contatoServico;
            _cartaoHistoricoServico = cartaoHistoricoServico;
            _unidadeDeTrabalho = unidadeDeTrabalho;
        }

        public async Task DesignarAsync(Cartao cartao)
        {
            await AtualizaCartaoComHistoricoAsync(cartao);
        }

        public async Task DevolverAsync(Cartao cartao)
        {
            await AtualizaCartaoComHistoricoAsync(cartao);
        }

        private async Task AtualizaCartaoComHistoricoAsync(Cartao cartao)
        {
            _unidadeDeTrabalho.IniciaTransacao();
            try
            {
                var cartaoModelo = _mapper.Map<CartaoModelo>(cartao);
                await _unidadeDeTrabalho.CartaoRepositorio.AtualizarAsync(cartaoModelo);

                var cartoesHistorico = await _cartaoHistoricoServico.ObterAsync(f => f.CartaoId == cartao.Id && f.PublicadorId == cartao.PublicadorId.Value && f.DataFim == null);
                var cartaoHistorico = cartoesHistorico?.Dados?.FirstOrDefault();
                if (cartaoHistorico == null)
                {
                    cartaoHistorico = new CartaoHistorico
                    {
                        CartaoId = cartao.Id,
                        PublicadorId = cartao.PublicadorId.Value,
                        DataInicio = cartao.DataInicio.Value,
                        DataFim = cartao.DataFim,
                        Observacao = cartao.Observacao
                    };

                    var cartaoHistoricoModelo = _mapper.Map<CartaoHistoricoModelo>(cartaoHistorico);
                    await _unidadeDeTrabalho.CartaoHistoricoRepositorio.InserirAsync(cartaoHistoricoModelo);
                }
                else
                {
                    cartaoHistorico.CartaoId = cartao.Id;
                    cartaoHistorico.PublicadorId = cartao.PublicadorId.Value;
                    cartaoHistorico.DataInicio = cartao.DataInicio.Value;
                    cartaoHistorico.DataFim = cartao.DataFim;
                    cartaoHistorico.Observacao = cartao.Observacao;

                    var cartaoHistoricoModelo = _mapper.Map<CartaoHistoricoModelo>(cartaoHistorico);
                    await _unidadeDeTrabalho.CartaoHistoricoRepositorio.AtualizarAsync(cartaoHistoricoModelo);
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

        public async Task<string> GerarDadosCartaoAsync(Cartao cartao, bool comFormatacao, bool colocarTracos)
        {
            var operadora = await _operadoraServico.ObterPorIdAsync(cartao.OperadoraId);
            var contatoContainerDados = await _contatoServico.ObterAsync(f => f.CartaoId == cartao.Id && f.PermiteLigar == true, informacaoPagina: _informacaoPagina);
            var contatos = contatoContainerDados.Dados.OrderBy(f => f.Numero);
            var codigoOperadoraFormatado = operadora.Codigo.ToString().PadLeft(3, '0');

            var cartaEmMemoria = new StringBuilder();

            cartaEmMemoria.AppendLine($@"Cartão N: {cartao.Numero} - Operadora {operadora.Nome} - Telefones {cartao.FaixaNumerica}");
            cartaEmMemoria.AppendLine("Legendas: (Revisita: R, Não ligar: NL, Não existe: NE, Não atendeu: NA)");
            cartaEmMemoria.AppendLine(string.Empty);
            cartaEmMemoria.AppendLine("Data de início: ____/____/____  Data da conclusão: ____/____/____");
            cartaEmMemoria.AppendLine(string.Empty);

            foreach (var contato in contatos)
            {
                var codigoArea = contato.Numero.Substring(0, contato.Numero.IndexOf(")"))
                    .Replace(" ", string.Empty)
                    .Replace("(", string.Empty)
                    .Replace(")", string.Empty)
                    .PadLeft(3, '0');

                var codigoCelular = contato.Numero.Substring(contato.Numero.IndexOf(")") + 1)
                    .Replace(" ", string.Empty)
                    .Replace("(", string.Empty)
                    .Replace(")", string.Empty);

                var numeroFormatado = string.Empty;

                if (comFormatacao)
                    numeroFormatado = $"({codigoArea}){codigoCelular}";
                else
                    numeroFormatado = $"{codigoArea}{codigoCelular}".Replace("-", string.Empty);

                if (colocarTracos)
                    cartaEmMemoria.AppendLine($@"{numeroFormatado} ____________________________________________");
                else
                    cartaEmMemoria.AppendLine($@"{numeroFormatado}");

                cartaEmMemoria.AppendLine(string.Empty);
            }

            return cartaEmMemoria.ToString();
        }

        public event CartoesContadosEventHandler CartoesContadosEventHandler;

        private void OnCartoesContados(int quantidadeTotalCartoes)
        {
            CartoesContadosEventHandler?.Invoke(this, new CartaoEventArgs { Quantidade = quantidadeTotalCartoes });
        }

        public event CartaoProcessadoEventHandler CartaoProcessadoEventHandler;

        private void OnCartaoProcessado(int quantidadeTotalCartoes, int itemAtual)
        {
            CartaoProcessadoEventHandler?.Invoke(this, new CartaoEventArgs { Quantidade = quantidadeTotalCartoes, ItemAtual = itemAtual });
        }

        public event CartoesExportadosEventHandler CartoesExportadosEventHandler;

        private void OnCartoesExportados(int quantidadeTotalCartoes)
        {
            CartoesExportadosEventHandler?.Invoke(this, new CartaoEventArgs { Quantidade = quantidadeTotalCartoes });
        }

        public async Task ExportarCartoesAsync(Expression<Func<Cartao, bool>> filter, string orderBy, string arquivoDestino)
        {
            var cartaoContainerDados = await ObterAsync(filter, orderBy, informacaoPagina: _informacaoPagina);
            var quantidadeTotalCartoes = cartaoContainerDados.Dados.Count;
            OnCartoesContados(quantidadeTotalCartoes);

            var documento = new XWPFDocument();
            var sectPr = documento.Document.body.sectPr;
            var pageMar = sectPr.pgMar;
            pageMar.top = "1.27cm";
            pageMar.bottom = "1.27cm";

            int contaCartoes = 0;

            try
            {

                foreach (var cartao in cartaoContainerDados.Dados)
                {
                    var cartaoId = cartao.Id;
                    var operadora = await _operadoraServico.ObterPorIdAsync(cartao.OperadoraId);

                    var contatoContainerDados = await _contatoServico.ObterAsync(f => f.CartaoId == cartaoId, nameof(Cartao.Id), informacaoPagina: _informacaoPagina);
                    var quantidadeTotalContatos = contatoContainerDados.Dados.Count;

                    var paragrafo1 = documento.CreateParagraph();
                    if (contaCartoes != 0)
                    {
                        var runQuebra = paragrafo1.CreateRun();
                        runQuebra.AddBreak(BreakType.PAGE);
                    }
                    paragrafo1.SpacingBefore = 0;
                    paragrafo1.SpacingBeforeLines = 0;
                    paragrafo1.SpacingBetween = 1;
                    paragrafo1.SpacingAfter = 0;
                    paragrafo1.SpacingAfterLines = 0;

                    var run1 = paragrafo1.CreateRun();
                    run1.SetText(string.Format("Cartão N: {0}", cartao.Numero));
                    run1.IsBold = true;

                    var run2 = paragrafo1.CreateRun();
                    run2.SetText($" - Operadora {operadora.Nome} - Telefones {cartao.FaixaNumerica}");

                    var paragrafo2 = documento.CreateParagraph();
                    paragrafo2.SpacingBefore = 0;
                    paragrafo2.SpacingBeforeLines = 0;
                    paragrafo2.SpacingBetween = 1;
                    paragrafo2.SpacingAfter = 0;
                    paragrafo2.SpacingAfterLines = 0;

                    var run3 = paragrafo2.CreateRun();
                    run3.SetText("Legendas:");
                    run3.IsBold = true;

                    var run4 = paragrafo2.CreateRun();
                    run4.SetText(" (Revisita: R, Não ligar: NL, Não existe: NE, Não atendeu: NA)");
                    run4.IsBold = false;

                    var paragrafo3 = documento.CreateParagraph();
                    paragrafo3.SpacingBefore = 1;
                    paragrafo3.SpacingBeforeLines = 0;
                    paragrafo3.SpacingBetween = 1;
                    paragrafo3.SpacingAfter = 1;
                    paragrafo3.SpacingAfterLines = 0;

                    var run5 = paragrafo3.CreateRun();
                    run5.SetText("Data de início: ____/____/____; Data da conclusão: ____/____/____");
                    run5.IsBold = true;

                    var paragrafo31 = documento.CreateParagraph();
                    paragrafo31.SpacingBefore = 1;
                    paragrafo31.SpacingBeforeLines = 0;
                    paragrafo31.SpacingBetween = 1;
                    paragrafo31.SpacingAfter = 1;
                    paragrafo31.SpacingAfterLines = 0;

                    var run51 = paragrafo3.CreateRun();
                    run51.SetText("");
                    run51.IsBold = true;

                    var table = documento.CreateTable(quantidadeTotalContatos + 1, 2);

                    table.Width = 5000;

                    table.SetColumnWidth(0, 1000);
                    table.SetColumnWidth(1, 4000);

                    var celulaCabecalho1 = table.GetRow(0).GetCell(0);
                    celulaCabecalho1.RemoveParagraph(0);
                    celulaCabecalho1.SetVerticalAlignment(XWPFTableCell.XWPFVertAlign.CENTER);
                    var paragrafoCelulaCabecalho1 = celulaCabecalho1.AddParagraph();
                    paragrafoCelulaCabecalho1.Alignment = ParagraphAlignment.CENTER;
                    paragrafoCelulaCabecalho1.SpacingBefore = 0;
                    paragrafoCelulaCabecalho1.SpacingBeforeLines = 0;
                    paragrafoCelulaCabecalho1.SpacingBetween = 1;
                    paragrafoCelulaCabecalho1.SpacingAfter = 0;
                    paragrafoCelulaCabecalho1.SpacingAfterLines = 0;

                    var run6 = paragrafoCelulaCabecalho1.CreateRun();
                    run6.SetText("Número");
                    run6.IsBold = true;

                    var celulaCabecalho2 = table.GetRow(0).GetCell(1);
                    celulaCabecalho2.RemoveParagraph(0);
                    celulaCabecalho2.SetVerticalAlignment(XWPFTableCell.XWPFVertAlign.CENTER);
                    var paragrafoCelulaCabecalho2 = celulaCabecalho2.AddParagraph();
                    paragrafoCelulaCabecalho2.Alignment = ParagraphAlignment.CENTER;
                    paragrafoCelulaCabecalho2.SpacingBefore = 0;
                    paragrafoCelulaCabecalho2.SpacingBeforeLines = 0;
                    paragrafoCelulaCabecalho2.SpacingBetween = 1;
                    paragrafoCelulaCabecalho2.SpacingAfter = 0;
                    paragrafoCelulaCabecalho2.SpacingAfterLines = 0;

                    var run7 = paragrafoCelulaCabecalho2.CreateRun();
                    run7.SetText("Observações");
                    run7.IsBold = true;

                    var contaContatos = 0;

                    foreach (var contato in contatoContainerDados.Dados)
                    {
                        var celulaItem1 = table.GetRow(contaContatos + 1).GetCell(0);
                        celulaItem1.RemoveParagraph(0);
                        celulaItem1.SetVerticalAlignment(XWPFTableCell.XWPFVertAlign.CENTER);
                        var paragrafoCelulaItem1 = celulaItem1.AddParagraph();
                        paragrafoCelulaItem1.Alignment = ParagraphAlignment.CENTER;
                        paragrafoCelulaItem1.SpacingBefore = 0;
                        paragrafoCelulaItem1.SpacingBeforeLines = 0;
                        paragrafoCelulaItem1.SpacingBetween = 1;
                        paragrafoCelulaItem1.SpacingAfter = 0;
                        paragrafoCelulaItem1.SpacingAfterLines = 0;

                        var codigoArea = contato.Numero.Substring(0, contato.Numero.IndexOf(")"))
                            .Replace(" ", string.Empty)
                            .Replace("(", string.Empty)
                            .Replace(")", string.Empty)
                            .PadLeft(3, '0');

                        var codigoCelular = contato.Numero.Substring(contato.Numero.IndexOf(")") + 1)
                            .Replace(" ", string.Empty)
                            .Replace("(", string.Empty)
                            .Replace(")", string.Empty);

                        var numeroFormatado = $"({codigoArea}){codigoCelular}";

                        var run8 = paragrafoCelulaItem1.CreateRun();
                        run8.SetText(numeroFormatado);
                        run8.IsBold = false;

                        var celulaItem2 = table.GetRow(contaContatos + 1).GetCell(1);
                        celulaItem2.RemoveParagraph(0);
                        celulaItem2.SetVerticalAlignment(XWPFTableCell.XWPFVertAlign.CENTER);

                        var paragrafoCelulaItem2 = celulaItem2.AddParagraph();
                        paragrafoCelulaItem2.Alignment = ParagraphAlignment.CENTER;
                        paragrafoCelulaItem2.SpacingBefore = 0;
                        paragrafoCelulaItem2.SpacingBeforeLines = 0;
                        paragrafoCelulaItem2.SpacingBetween = 1;
                        paragrafoCelulaItem2.SpacingAfter = 0;
                        paragrafoCelulaItem2.SpacingAfterLines = 0;

                        var run9 = paragrafoCelulaItem2.CreateRun();
                        run9.SetText("");
                        run9.IsBold = false;

                        contaContatos += 1;
                    }

                    contaCartoes += 1;
                    OnCartaoProcessado(quantidadeTotalCartoes, contaCartoes);
                }

                using (var arquivo = new FileStream(arquivoDestino, FileMode.Create))
                {
                    documento.Write(arquivo);
                }

            }
            finally
            {
                documento.Close();
                OnCartoesExportados(quantidadeTotalCartoes);
            }
        }
    }
}

