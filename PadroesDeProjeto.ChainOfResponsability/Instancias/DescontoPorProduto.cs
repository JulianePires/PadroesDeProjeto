namespace PadroesDeProjeto.ChainOfResponsability.Instancias;

public class DescontoPorProduto : IDesconto
{
    private Helper helper = new();
    public IDesconto Proximo { get; set; }

    public double Desconta(Venda venda)
    {
        var existeItem = helper.Existe("Molho de Tomate", venda);
        
        if (existeItem)
        {
            return venda.Valor * 0.3;
        }
        else
        {
            return Proximo.Desconta(venda);
        }
    }
}