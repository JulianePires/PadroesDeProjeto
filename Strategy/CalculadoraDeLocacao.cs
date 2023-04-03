namespace PadroesDeProjeto.Strategy
{
    public class CalculadoraDeLocacao
    {
        public double RealizaLocacao(Locacao locacao, IFaixaDeCalculo faixa)
        {
            var valorFinal = locacao.ValorFixo + faixa.CalculaLocacao(locacao.DiasDeLocacao);
            return valorFinal;
        }
    }
}
