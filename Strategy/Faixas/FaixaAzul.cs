namespace Strategy.Faixas;

public class FaixaAzul : IFaixaDeCalculo
{
    public double CalculaLocacao(TimeSpan tempo)
    {
        return tempo.Days * 0.4;
    }
}