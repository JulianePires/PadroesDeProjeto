namespace PadroesDeProjeto.ChainOfResponsability.Instancias;

public class DescontoPorValorVenda : IDesconto
{
    public IDesconto Proximo { get; set; }
    
    public double Desconta(Venda venda)
    {
        if(venda.Valor >= 30.00)
        {
            return venda.Valor * 0.4;
        }
        else
        {
            return Proximo.Desconta(venda);
        }
    }
}