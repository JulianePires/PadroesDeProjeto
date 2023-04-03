using PadroesDeProjeto.Decorator.Helpers;

namespace PadroesDeProjeto.Tests.Decorator.Helpers
{
    public class TesteFormatador
    {
        [Theory]
        [InlineData(2.567, "2.57")]
        [InlineData(10, "10.00")]
        [InlineData(200000, "200,000.00")]
        [InlineData(100000000, "100,000,000.00")]
        public void DeveRetornarPrecoInformadoEmStringNoFormatoAdequado(double preco, string stringEsperada)
        {
            var stringFormatada = Formatador.FormataPreco(preco);

            Assert.Equal(stringEsperada, stringFormatada);
        }
    }
}
