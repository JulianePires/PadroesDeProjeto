namespace PadroesDeProjeto.Strategy.Faixas;

public class FaixaBranca : IFaixaDeCalculo
{
    public double CalculaLocacao(int diasDeLocacao)
    {
        return diasDeLocacao * 0.5;
    }
}