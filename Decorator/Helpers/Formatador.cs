namespace PadroesDeProjeto.Decorator.Helpers
{
    public class Formatador
    {
        public static string FormataPreco(double preco) => string.Format("{0:0,0.00}", preco);
    }
}
