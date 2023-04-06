namespace PadroesDeProjeto.Decorator.Decorators
{
    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza? _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public PizzaDecorator()
        {
            _pizza = null;
        }

        public abstract double CalculaValor();

        public abstract string PedePizza();

        protected double CalculaOutroValor()
        {
            return (_pizza == null ? new Pizza().CalculaValor() : _pizza.CalculaValor());
        }

        protected string PedeOutraPizza()
        {
            return (_pizza == null ? new Pizza().PedePizza() : _pizza.PedePizza());
        }
    }
}
