namespace Strategy.Faixas;

public class FaixaBranca : IFaixaDeCalculo
{
    public double CalculaLocacao(TimeSpan tempo)
    {
        return tempo.Days * 0.5;
    }
}