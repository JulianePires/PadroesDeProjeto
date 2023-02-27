namespace PadroesDeProjeto.ChainOfResponsability.Instancias;

public class SemDesconto : IDesconto
{
    public double Desconta(Venda venda)
    {
        return 0;
    }

    public IDesconto Proximo { get; set; }
}