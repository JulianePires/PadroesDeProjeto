namespace Strategy.Faixas;

public class FaixaAmarela : IFaixaDeCalculo
{
    public double CalculaLocacao(TimeSpan tempo)
    {
        return tempo.Days * 0.7;
    }
}