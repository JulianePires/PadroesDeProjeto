namespace Strategy.Faixas;

public class FaixaVerde : IFaixaDeCalculo
{
    public double CalculaLocacao(int diasDeLocacao)
    {
        return diasDeLocacao * 0.6;
    }
}