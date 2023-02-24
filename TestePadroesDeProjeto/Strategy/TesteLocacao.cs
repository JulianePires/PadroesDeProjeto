using PadroesDeProjeto.Strategy;
using PadroesDeProjeto.Strategy.Faixas;

namespace PadroesDeProjeto.Tests.Strategy;

public class TesteLocacao
{
    private Locacao _locacao = new("Ponciá Vicêncio", 2);
    CalculadoraDeLocacao _calculadora = new();

    private double CalculaLocacaoPorRegra(double porcentagem)
    {
        return _locacao.ValorFixo + _locacao.DiasDeLocacao * porcentagem;
    }

    [Fact]
    public void DEVE_CALCULAR_LOCACAO_DE_ACORDO_COM_A_PORCENTAGEM_DA_FAIXA_AZUL()
    {
        var regraFaixaAzul = 0.4;
        var valorCalculado = CalculaLocacaoPorRegra(regraFaixaAzul);
        IFaixaDeCalculo faixaAzul = new FaixaAzul();

        var valorFinalLocacao = _calculadora.RealizaLocacao(_locacao, faixaAzul);

        Assert.Equal(valorCalculado, valorFinalLocacao);
    }

    [Fact]
    public void DEVE_CALCULAR_LOCACAO_DE_ACORDO_COM_A_PORCENTAGEM_DA_FAIXA_BRANCA()
    {
        var regraFaixaBranca = 0.5;
        var valorCalculado = CalculaLocacaoPorRegra(regraFaixaBranca);
        IFaixaDeCalculo faixaBranca = new FaixaBranca();

        var valorFinalLocacao = _calculadora.RealizaLocacao(_locacao, faixaBranca);

        Assert.Equal(valorCalculado, valorFinalLocacao);
    }

    [Fact]
    public void DEVE_CALCULAR_LOCACAO_DE_ACORDO_COM_A_PORCENTAGEM_DA_FAIXA_VERDE()
    {
        var regraFaixaVerde = 0.6;
        var valorCalculado = CalculaLocacaoPorRegra(regraFaixaVerde);
        IFaixaDeCalculo faixaVerde = new FaixaVerde();

        var valorFinalLocacao = _calculadora.RealizaLocacao(_locacao, faixaVerde);

        Assert.Equal(valorCalculado, valorFinalLocacao);
    }

    [Fact]
    public void DEVE_CALCULAR_LOCACAO_DE_ACORDO_COM_A_PORCENTAGEM_DA_FAIXA_AMARELA()
    {
        var regraFaixaAmarela = 0.7;
        var valorCalculado = CalculaLocacaoPorRegra(regraFaixaAmarela);
        IFaixaDeCalculo faixaAmarela = new FaixaAmarela();

        var valorFinalLocacao = _calculadora.RealizaLocacao(_locacao, faixaAmarela);

        Assert.Equal(valorCalculado, valorFinalLocacao);
    }
}