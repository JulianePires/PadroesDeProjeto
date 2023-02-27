namespace PadroesDeProjeto.ChainOfResponsability.Instancias;

public class DescontoPorQuantidade : IDesconto
{
    public IDesconto Proximo { get; set; }

    public double Desconta(Venda venda)
    {
        if (venda.Itens.Count > 5)
        {
            return venda.Valor * 0.1;
        }
        else
        {
            return Proximo.Desconta(venda);
        }
    }
}