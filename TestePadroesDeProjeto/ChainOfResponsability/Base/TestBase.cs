using PadroesDeProjeto.ChainOfResponsability.Instancias;
using PadroesDeProjeto.ChainOfResponsability;

namespace PadroesDeProjeto.Tests.ChainOfResponsability.Base;

public abstract class TestBase : IDisposable
{
    public static Venda Venda;
    public static Item Cebola;
    public static Item Tomate;
    public static Item MolhoDeTomate;
    public static Item Xampu;
    public static Item Macarrao;
    public static Item Pao;
    public static IDesconto SemDesconto;

    protected TestBase()
    {
        Venda = new Venda();
        Cebola = new Item("Cebola", 2.5);
        Tomate = new Item("Tomate", 3.5);
        MolhoDeTomate = new Item("Molho de Tomate", 4.0);
        Xampu = new Item("Xampu", 12.00);
        Macarrao = new Item("Macarrao", 3.0);
        Pao = new Item("Pao", 4.0);
        SemDesconto = new SemDesconto();
    }

    public void Dispose()
    {
        Venda = new Venda();
    }

    private static void ResetaVenda()
    {
        Venda = new Venda();
    }

    public static void AdicionaMolhoDeTomateAVenda()
    {
        ResetaVenda();
        Venda.AdicionaItem(MolhoDeTomate);
    }

    public static void AdicionaVendaCasada()
    {
        ResetaVenda();
        Venda.AdicionaItem(Macarrao);
        Venda.AdicionaItem(Cebola);
    }

    public static void AdicionaMaisDeCincoItens()
    {
        ResetaVenda();
        Venda.AdicionaItem(MolhoDeTomate);
        Venda.AdicionaItem(Cebola);
        Venda.AdicionaItem(Tomate);
        Venda.AdicionaItem(Pao);
        Venda.AdicionaItem(Xampu);
        Venda.AdicionaItem(Macarrao);
    } 

    public static void AdicionaValorMaiorQueTrinta()
    {
        ResetaVenda();
        Venda.AdicionaItem(Xampu);
        Venda.AdicionaItem(Xampu);
        Venda.AdicionaItem(Xampu);
    }

    public static void AdicionaItensForaDosDescontos()
    {
        ResetaVenda();
        Venda.AdicionaItem(Xampu);
        Venda.AdicionaItem(Tomate);
        Venda.AdicionaItem(Cebola);
    }
}