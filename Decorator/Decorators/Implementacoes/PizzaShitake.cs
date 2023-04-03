namespace PadroesDeProjeto.Decorator.Decorators.Implementacoes
{
    public class PizzaShitake : PizzaDecorator
    {
        public PizzaShitake(IPizza outraPizza) : base(outraPizza) { }

        public PizzaShitake() : base() { }

        public override double CalculaValor()
        {
            return CalculaOutroValor() + 14.00;
        }

        public override string PedePizza()
        {
            return PedeOutraPizza() + " + shitake";
        }
    }
}
