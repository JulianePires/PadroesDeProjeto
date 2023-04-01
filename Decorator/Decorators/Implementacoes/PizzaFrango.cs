namespace PadroesDeProjeto.Decorator.Decorators.Implementacoes
{
    public class PizzaFrango : PizzaDecorator
    {
        public PizzaFrango(IPizza outraPizza) : base(outraPizza) { }

        public PizzaFrango() : base() { }

        public override double CalculaValor()
        {
            return CalculaOutroValor() + 12.00;
        }

        public override string PedePizza()
        {
            return PedeOutraPizza() + " + frango";
        }
    }
}
