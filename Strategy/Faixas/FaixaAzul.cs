namespace Strategy.Faixas;

public class FaixaAzul : IFaixaDeCalculo
{
    public double CalculaLocacao(int diasDeLocacao)
    {
        return diasDeLocacao * 0.4;
    }
}