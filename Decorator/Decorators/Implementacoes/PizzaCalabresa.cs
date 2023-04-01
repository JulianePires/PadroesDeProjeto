namespace PadroesDeProjeto.Decorator.Decorators.Implementacoes
{
    public class PizzaCalabresa : PizzaDecorator
    {
        public PizzaCalabresa(IPizza outraPizza) : base(outraPizza) { }

        public PizzaCalabresa() : base() { }

        public override double CalculaValor()
        {
            return CalculaOutroValor() + 10.00;
        }

        public override string PedePizza()
        {
            return PedeOutraPizza() + " + calabresa";
        }
    }
}
