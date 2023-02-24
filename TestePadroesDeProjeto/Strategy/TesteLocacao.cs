using Strategy;
using Strategy.Faixas;
using System.Text.RegularExpressions;

namespace TestePadroesDeProjeto.Strategy;

public class TesteLocacao
{
    private double _valorFixo = 20.00;
    private TimeSpan _tempoDeLocacao = TimeSpan.FromDays(2);
    CalculadoraDeLocacao _calculadora = new CalculadoraDeLocacao();

    private double CalculaLocacaoPorRegra(double porcentagem)
    {
        return _valorFixo + _tempoDeLocacao.Days * porcentagem;
    }

    [Fact]
    public void DEVE_CALCULAR_LOCACAO_DE_ACORDO_COM_A_PORCENTAGEM_DA_FAIXA_AZUL()
    {
        var regraFaixaAzul = 0.4;
        var valorCalculado = CalculaLocacaoPorRegra(regraFaixaAzul);
        IFaixaDeCalculo faixaAzul = new FaixaAzul();

        var valorFinalLocacao = _calculadora.RealizaLocacao(_tempoDeLocacao, faixaAzul);

        Assert.Equal(valorCalculado, valorFinalLocacao);
    }

    [Fact]
    public void DEVE_CALCULAR_LOCACAO_DE_ACORDO_COM_A_PORCENTAGEM_DA_FAIXA_BRANCA()
    {
        var regraFaixaBranca = 0.5;
        var valorCalculado = CalculaLocacaoPorRegra(regraFaixaBranca);
        IFaixaDeCalculo faixaBranca = new FaixaBranca();

        var valorFinalLocacao = _calculadora.RealizaLocacao(_tempoDeLocacao, faixaBranca);

        Assert.Equal(valorCalculado, valorFinalLocacao);
    }

    [Fact]
    public void DEVE_CALCULAR_LOCACAO_DE_ACORDO_COM_A_PORCENTAGEM_DA_FAIXA_VERDE()
    {
        var regraFaixaVerde = 0.6;
        var valorCalculado = CalculaLocacaoPorRegra(regraFaixaVerde);
        IFaixaDeCalculo faixaVerde = new FaixaVerde();

        var valorFinalLocacao = _calculadora.RealizaLocacao(_tempoDeLocacao, faixaVerde);

        Assert.Equal(valorCalculado, valorFinalLocacao);
    }

    [Fact]
    public void DEVE_CALCULAR_LOCACAO_DE_ACORDO_COM_A_PORCENTAGEM_DA_FAIXA_AMARELA()
    {
        var regraFaixaAmarela = 0.7;
        var valorCalculado = CalculaLocacaoPorRegra(regraFaixaAmarela);
        IFaixaDeCalculo faixaAmarela = new FaixaAmarela();

        var valorFinalLocacao = _calculadora.RealizaLocacao(_tempoDeLocacao, faixaAmarela);

        Assert.Equal(valorCalculado, valorFinalLocacao);
    }
}