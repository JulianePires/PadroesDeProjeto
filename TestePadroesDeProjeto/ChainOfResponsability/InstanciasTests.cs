using PadroesDeProjeto.ChainOfResponsability.Instancias;
using PadroesDeProjeto.ChainOfResponsability;
using PadroesDeProjeto.Tests.ChainOfResponsability.Base;

namespace PadroesDeProjeto.Tests.ChainOfResponsability;

public class InstanciasTests : TestBase
{
    [Fact]
    public void DEVE_RETORNAR_ZERO_SE_NENHUM_DESCONTO_FOR_APLICADO()
    {
        IDesconto desconto = new SemDesconto();
        desconto.Proximo = SemDesconto;
        var valorEsperado = 0;

        AdicionaMaisDeCincoItens();
        var valorDesconto = desconto.Desconta(Venda);

        Assert.Equal(valorEsperado, valorDesconto);
    }

    [Fact]
    public void DEVE_RETORNAR_TRINTA_PORCENTO_DO_VALOR_SE_SE_APLICADO_DESCONTO_POR_PRODUTO()
    {
        IDesconto desconto = new DescontoPorProduto();
        desconto.Proximo = SemDesconto;

        Venda.AdicionaItem(Tomate);
        AdicionaMolhoDeTomateAVenda();
        var valorEsperado = Venda.Valor * 0.3;
        var valorDesconto = desconto.Desconta(Venda);

        Assert.Equal(valorEsperado, valorDesconto);
    }

    [Fact]
    public void DEVE_RETORNAR_VINTE_PORCENTO_DO_VALOR_SE_APLICADO_DESCONTO_POR_VENDA_CASADA()
    {
        IDesconto desconto = new DescontoPorVendaCasada();
        desconto.Proximo = SemDesconto;

        AdicionaVendaCasada();
        var valorEsperado = Venda.Valor * 0.2;
        var valorDesconto = desconto.Desconta(Venda);

        Assert.Equal(valorEsperado, valorDesconto);
    }

    [Fact]
    public void DEVE_RETORNAR_DEZ_PORCENTO_DO_VALOR_SE_APLICADO_DESCONTO_POR_QUANTIDADE()
    {
        IDesconto desconto = new DescontoPorQuantidade();
        desconto.Proximo = SemDesconto;

        AdicionaMaisDeCincoItens();
        var valorEsperado = Venda.Valor * 0.1;
        var valorDesconto = desconto.Desconta(Venda);

        Assert.Equal(valorEsperado, valorDesconto);
    }

    [Fact]
    public void DEVE_RETORNAR_QUARENTA_PORCENTO_DO_VALOR_SE_APLICADO_DESCONTO_POR_VALOR_DE_VENDA()
    {
        IDesconto desconto = new DescontoPorValorVenda();
        desconto.Proximo = SemDesconto;

        AdicionaValorMaiorQueTrinta();
        var valorEsperado = Venda.Valor * 0.4;
        var valorDesconto = desconto.Desconta(Venda);

        Assert.Equal(valorEsperado, valorDesconto);
    }
}