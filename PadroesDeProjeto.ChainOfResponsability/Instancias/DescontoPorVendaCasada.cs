namespace PadroesDeProjeto.ChainOfResponsability.Instancias;

public class DescontoPorVendaCasada : IDesconto
{
    private Helper helper = new();
    public IDesconto Proximo { get; set; }

    public double Desconta(Venda venda)
    {
        var existeVendaCasada = helper.Existe("Cebola", venda) && helper.Existe("Macarrao", venda);
        
        if (existeVendaCasada)
        {
            return venda.Valor * 0.2;
        }
        else
        {
            return Proximo.Desconta(venda);
        }
    }
}