namespace Strategy.Faixas;

public class FaixaVerde : IFaixaDeCalculo
{
    public double CalculaLocacao(TimeSpan tempo)
    {
        return tempo.Days * 0.6;
    }
}