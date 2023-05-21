using PadroesDeProjeto.Builder.Builders;
using PadroesDeProjeto.Builder.Domain.Enums;

namespace PadroesDeProjeto.Tests.Builder
{
    public class TesteFilmeBuilder
    {
        [Fact]
        public void DeveConstruirUmFilmeComIdAleatórioQuandoNãoHouverPropriedades()
        {
            var filme = new FilmeBuilder().Constroi();

            Assert.NotNull(filme.Id);
            Assert.Null(filme.Titulo);
            Assert.Equal(filme.Ano, 0);
            Assert.Equal(filme.Genero, Genero.Acao);
            Assert.Empty(filme.Diretores);
            Assert.Empty(filme.Elenco);
            Assert.False(filme.EmCartaz);
        }

        [Fact]
        public void DeveConstruirUmFilmeComOIdInformadoAoUtilizarMetodoComId()
        {
            var idEsperado = "01";
            var filme = new FilmeBuilder().ComId(idEsperado).Constroi();

            Assert.Equal(idEsperado, filme.Id);
        }

        [Fact]
        public void DeveConstruirUmFilmeComOTituloInformadoAoUtilizarMetodoComTitulo()
        {
            var filmeEsperado = "Titanic";
            var filme = new FilmeBuilder().ComTitulo(filmeEsperado).Constroi();

            Assert.Equal(filmeEsperado, filme.Titulo);
        }

        [Fact]
        public void DeveConstruirUmFilmeComOAnoInformadoAoUtilizarMetodoComAno()
        {
            var anoEsperado = 1992;
            var filme = new FilmeBuilder().ComAno(anoEsperado).Constroi();

            Assert.Equal(anoEsperado, filme.Ano);
        }

        [Fact]
        public void DeveConstruirUmFilmeComDiretoresInformadosAoUtilizarMetodoComDiretores()
        {
            var diretoresEsperados = new List<string>() { "João Silva", "Maria Souza" };
            var filme = new FilmeBuilder().ComDiretores(diretoresEsperados).Constroi();

            Assert.Equal(diretoresEsperados, filme.Diretores);
        }

        [Fact]
        public void DeveConstruirUmFilmeComOGeneroInformadoAoUtilizarMetodoComGenero()
        {
            var generoEsperado = Genero.Faroeste;
            var filme = new FilmeBuilder().ComGenero(generoEsperado).Constroi();

            Assert.Equal(generoEsperado, filme.Genero);
        }

        [Fact]
        public void DeveConstruirUmFilmeComElencoInformadoAoUtilizarMetodoComElenco()
        {
            var elencoEsperado = new List<string>() { "João Silva", "Maria Souza" };
            var filme = new FilmeBuilder().ComElenco(elencoEsperado).Constroi();

            Assert.Equal(elencoEsperado, filme.Elenco);
        }

        [Fact]
        public void DeveConstruirUmFilmeComEmCartazAoUtilizarMetodoEmCartaz()
        {
            var filme = new FilmeBuilder().ComEmCartaz(true).Constroi();

            Assert.True(filme.EmCartaz);
        }
    }
}
