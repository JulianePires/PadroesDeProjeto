namespace PadroesDeProjeto.Decorator
{
    public class Pizza : IPizza
    {
        public string PedePizza()
        {
            return "Pizza de mussarela";
        }

        public double CalculaValor()
        {
            return 20.00;
        }
    }
}
