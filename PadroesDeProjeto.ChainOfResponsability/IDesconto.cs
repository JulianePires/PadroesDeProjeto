namespace PadroesDeProjeto.ChainOfResponsability;

public interface IDesconto
{
    double Desconta(Venda venda);
    IDesconto Proximo { get; set; }
}