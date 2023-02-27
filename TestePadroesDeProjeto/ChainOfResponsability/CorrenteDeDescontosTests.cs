using PadroesDeProjeto.ChainOfResponsability;
using PadroesDeProjeto.ChainOfResponsability.Instancias;
using PadroesDeProjeto.Tests.ChainOfResponsability.Base;

namespace PadroesDeProjeto.Tests.ChainOfResponsability;

public class CorrenteDeDescontosTests : TestBase
{
    CorrenteDeDescontos _corrente;

    public CorrenteDeDescontosTests()
    {
        _corrente = new CorrenteDeDescontos();
    }

    [Fact]
    public void DEVE_RETORNAR_DESCONTO_DE_TRINTA_PORCENTO_SE_VENDA_POSSUIR_MOLHO_DE_TOMATE()
    {
        AdicionaMaisDeCincoItens();
        var valorEsperado = Venda.Valor * 0.3;
        var valorDesconto = _corrente.Calcula(Venda);

        Assert.Equal(valorEsperado, valorDesconto);
    }

    [Fact]
    public void DEVE_RETORNAR_DESCONTO_DE_VINTE_PORCENTO_SE_NAO_POSSUIR_MOLHO_DE_TOMATE_E_VENDA_POSSUIR_VENDA_CASADA()
    {
        AdicionaVendaCasada();
        Venda.AdicionaItem(Xampu);
        Venda.AdicionaItem(Pao);
        var valorEsperado = Venda.Valor * 0.2;
        var valorDesconto = _corrente.Calcula(Venda);

        Assert.Equal(valorEsperado, valorDesconto);
    }

    [Fact]
    public void DEVE_RETORNAR_DESCONTO_DE_DEZ_PORCENTO_SE_NAO_POSSUIR_VENDA_CASADA_PRODUTO_E_VENDA_POSSUIR_MAIS_ITENS_QUE_QUANTIDADE()
    {
        Venda.AdicionaItem(Cebola);
        Venda.AdicionaItem(Tomate);
        Venda.AdicionaItem(Xampu);
        Venda.AdicionaItem(Pao);
        Venda.AdicionaItem(Xampu);
        Venda.AdicionaItem(Tomate);
        var valorDesconto = _corrente.Calcula(Venda);
        var valorEsperado = Venda.Valor * 0.1;

        Assert.Equal(valorEsperado, valorDesconto);
    }

    [Fact]
    public void DEVE_RETORNAR_DESCONTO_DE_QUARENTA_PORCENTO_SE_NAO_POSSUIR_VENDA_CASADA_PRODUTO_QUANTIDADE_E_VENDA_POSSUIR_VALOR_MAIOR()
    {
        AdicionaValorMaiorQueTrinta();
        var valorDesconto = _corrente.Calcula(Venda);
        var valorEsperado = Venda.Valor * 0.4;

        Assert.Equal(valorEsperado, valorDesconto);
    }

    [Fact]
    public void DEVE_RETORNAR_DESCONTO_ZERO_SE_VENDA_NAO_ATENDER_NENHUM_REQUISITO()
    {
        AdicionaItensForaDosDescontos();
        var valorEsperado = 0;
        var valorDesconto = _corrente.Calcula(Venda);

        Assert.Equal(valorEsperado, valorDesconto);
    }
}