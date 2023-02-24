namespace Strategy
{
    public class CalculadoraDeLocacao
    {
        public double RealizaLocacao(TimeSpan tempo, IFaixaDeCalculo faixa)
        {
            double valorFixo = 20.00;
            var valorFinal = valorFixo + faixa.CalculaLocacao(tempo);
            return valorFinal;
        }
    }
}
