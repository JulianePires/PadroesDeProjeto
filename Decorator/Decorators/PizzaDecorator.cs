namespace PadroesDeProjeto.Decorator.Decorators
{
    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza? Pizza;

        public PizzaDecorator(IPizza pizza)
        {
            Pizza = pizza;
        }

        public PizzaDecorator()
        {
            Pizza = null;
        }

        public abstract double CalculaValor();

        public abstract string PedePizza();

        protected double CalculaOutroValor()
        {
            return (Pizza == null ? new Pizza().CalculaValor() : Pizza.CalculaValor());
        }

        protected string PedeOutraPizza()
        {
            return (Pizza == null ? new Pizza().PedePizza() : Pizza.PedePizza());
        }
    }
}
