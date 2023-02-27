using PadroesDeProjeto.ChainOfResponsability.Instancias;

namespace PadroesDeProjeto.ChainOfResponsability;

public class CorrenteDeDescontos
{
    public double Calcula(Venda venda)
    {
        IDesconto descontoPorProduto = new DescontoPorProduto();
        IDesconto descontoPorVendaCasada = new DescontoPorVendaCasada();
        IDesconto descontoPorQuantidade = new DescontoPorQuantidade();
        IDesconto descontoPorValorVenda = new DescontoPorValorVenda();
        IDesconto semDesconto = new SemDesconto();

        descontoPorProduto.Proximo = descontoPorVendaCasada;
        descontoPorVendaCasada.Proximo = descontoPorQuantidade;
        descontoPorQuantidade.Proximo = descontoPorValorVenda;
        descontoPorValorVenda.Proximo = semDesconto;

        return descontoPorProduto.Desconta(venda);
    }
}