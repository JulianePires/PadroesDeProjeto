// See https://aka.ms/new-console-template for more information
using PadroesDeProjeto.Decorator;
using PadroesDeProjeto.Decorator.Decorators.Implementacoes;
using PadroesDeProjeto.Decorator.Helpers;

IPizza pizza = new Pizza();
IPizza pizzaCalabresa = new PizzaCalabresa();
IPizza pizzaCalabresaComFrango = new PizzaCalabresa(new PizzaFrango());

Console.WriteLine("Pizza: " + pizza.PedePizza() + " | Valor: R$" + Formatador.FormataPreco(pizza.CalculaValor()));
Console.WriteLine("Pizza: " + pizzaCalabresa.PedePizza() + " | Valor: R$" + Formatador.FormataPreco(pizzaCalabresa.CalculaValor()));
Console.WriteLine("Pizza: " + pizzaCalabresaComFrango.PedePizza() + " | Valor: R$" + Formatador.FormataPreco(pizzaCalabresaComFrango.CalculaValor()));
