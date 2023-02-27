using PadroesDeProjeto.ChainOfResponsability;
using PadroesDeProjeto.Tests.ChainOfResponsability.Base;

namespace PadroesDeProjeto.Tests.ChainOfResponsability;

public class HelperTests : TestBase
{
    Helper _helper;

    public HelperTests()
    {
        _helper = new Helper();
    }

    [Fact]
    public void DEVE_RETORNAR_VERDADEIRO_SE_VENDA_POSSUIR_ITEM()
    {
        Venda.AdicionaItem(Cebola);
        var nomeItem = "Cebola";

        var resposta = _helper.Existe(nomeItem, Venda);

        Assert.True(resposta);
    }

    [Fact]
    public void DEVE_RETORNAR_FALSO_SE_VENDA_NAO_POSSUIR_ITEM()
    {
        Venda.AdicionaItem(Tomate);
        var nomeItem = "Cebola";

        var resposta = _helper.Existe(nomeItem, Venda);

        Assert.False(resposta);
    }
}