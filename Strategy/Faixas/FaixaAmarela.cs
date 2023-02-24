namespace Strategy.Faixas;

public class FaixaAmarela : IFaixaDeCalculo
{
    public double CalculaLocacao(int diasDeLocacao)
    {
        return diasDeLocacao * 0.7;
    }
}