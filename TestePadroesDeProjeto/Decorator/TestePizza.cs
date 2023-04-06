using PadroesDeProjeto.Decorator;
using PadroesDeProjeto.Decorator.Decorators.Implementacoes;

namespace PadroesDeProjeto.Tests.Decorator
{
    public class TestePizza
    {
        [Fact]
        public void DeveRetornarDescricaoEPrecoPadraoQuandoNaoHouverDecorador()
        {
            var valorEsperado = 20;
            var descricaoEsperada = "Pizza de mussarela";
            IPizza pizza = new Pizza();

            var valorPizza = pizza.CalculaValor();
            var descricaoPizza = pizza.PedePizza();

            Assert.Equal(valorEsperado, valorPizza);
            Assert.Equal(descricaoEsperada, descricaoPizza);
        }

        [Fact]
        public void DeveRetornarPropriedadesPadraoAdicionadasAoComportamentoDosDecoradoresConcatenados()
        {
            var valorEsperado = 20 + 10 + 14;
            var descricaoEsperada = "Pizza de mussarela" + " + shitake" + " + calabresa";
            IPizza pizzaShitake = new PizzaShitake();
            IPizza pizzaCalabresaShitake = new PizzaCalabresa(pizzaShitake);

            var valorPizza = pizzaCalabresaShitake.CalculaValor();
            var descricaoPizza = pizzaCalabresaShitake.PedePizza();

            Assert.Equal(valorEsperado, valorPizza);
            Assert.Equal(descricaoEsperada, descricaoPizza);
        }

        [Fact]
        public void DeveRetornarPropriedadesPadraoAdicionadasAoComportamentoDoDecorador()
        {
            var valorEsperado = 20 + 10;
            var descricaoEsperada = "Pizza de mussarela" + " + calabresa";
            IPizza pizza = new PizzaCalabresa();

            var valorPizza = pizza.CalculaValor();
            var descricaoPizza = pizza.PedePizza();

            Assert.Equal(valorEsperado, valorPizza);
            Assert.Equal(descricaoEsperada, descricaoPizza);
        }
    }
}
