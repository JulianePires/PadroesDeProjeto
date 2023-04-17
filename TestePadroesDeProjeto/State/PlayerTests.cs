using PadroesDeProjeto.State.Estados;
using PadroesDeProjeto.State.Estados.Implementacoes;
using PadroesDeProjeto.Tests.Helpers.Builders.State;

namespace PadroesDeProjeto.Tests.State
{
    public class PlayerTests
    {
        [Fact]
        public void PlayerShouldAddARescuedPrisionerWhenStateIsEmAndamentoAndSalvaPrisioneiroMethodIsCalled()
        {
            var prisioneirosSalvosInicial = 1;
            var prisioneirosSalvosEsperados = 2;
            var player = new PlayerBuilder().WithRescuedPrisioners(prisioneirosSalvosInicial).Generate();

            player.SalvaPrisioneiro();

            Assert.StrictEqual(prisioneirosSalvosEsperados, player.PrisioneirosSalvos);
        }

        [Fact]
        public void SalvaPrisioneiroShouldThrowAnExceptionWhenCalledWithZeradoState()
        {
            var prisioneirosSalvosInicial = 1;
            var prisioneirosSalvosEsperados = 1;
            var player = new PlayerBuilder().WithStateAndRescuedPrisioners(
                new Zerado(), prisioneirosSalvosInicial).Generate();
            var excecaoEsperada = $"Player {player.Nome} já zerou o game, não pode salvar mais prisioneiros.";

            var excecao = Assert.Throws<Exception>(() => player.SalvaPrisioneiro());

            Assert.Equal(excecaoEsperada, excecao.Message);
            Assert.StrictEqual(prisioneirosSalvosEsperados, player.PrisioneirosSalvos);
        }

        [Fact]
        public void SalvaPrisioneiroShouldThrowAnExceptionWhenCalledWithPerdidoState()
        {
            var prisioneirosSalvosInicial = 1;
            var prisioneirosSalvosEsperados = 1;
            var player = new PlayerBuilder().WithStateAndRescuedPrisioners(
                new Perdido(), prisioneirosSalvosInicial).Generate();
            var excecaoEsperada = $"Player {player.Nome} já perdeu o game, não pode salvar mais prisioneiros.";

            var excecao = Assert.Throws<Exception>(() => player.SalvaPrisioneiro());

            Assert.Equal(excecaoEsperada, excecao.Message);
            Assert.StrictEqual(prisioneirosSalvosEsperados, player.PrisioneirosSalvos);
        }

        [Fact]
        public void SalvaPrisioneiroShouldThrowAnExceptionWhenCalledWithFinalizadoState()
        {
            var prisioneirosSalvosInicial = 1;
            var prisioneirosSalvosEsperados = 1;
            var player = new PlayerBuilder().WithStateAndRescuedPrisioners(
                new Finalizado(), prisioneirosSalvosInicial).Generate();
            var excecaoEsperada = $"Player {player.Nome} já finalizou o game, não pode salvar mais prisioneiros.";

            var excecao = Assert.Throws<Exception>(() => player.SalvaPrisioneiro());

            Assert.Equal(excecaoEsperada, excecao.Message);
            Assert.StrictEqual(prisioneirosSalvosEsperados, player.PrisioneirosSalvos);
        }

        [Fact]
        public void PlayerShouldHaveTwentyMorePointsWhenHaveEmAndamentoStateAndGanhaPontosExtrasMethodIsCalledWithoutPrisioners()
        {
            var player = new PlayerBuilder().WithState(new EmAndamento()).Generate();
            var pontosIniciais = player.Pontuacao;

            player.GanhaPontosExtras();

            Assert.StrictEqual(pontosIniciais + 20, player.Pontuacao);
        }

        [Fact]
        public void PlayerShouldHaveFortyMorePointsWhenHaveZeradoStateAndGanhaPontosExtrasMethodIsCalledWithoutPrisioners()
        {
            var player = new PlayerBuilder().WithState(new Zerado()).Generate();
            var pontosIniciais = player.Pontuacao;

            player.GanhaPontosExtras();

            Assert.StrictEqual(pontosIniciais + 40, player.Pontuacao);
        }

        [Fact]
        public void GanhaPontosExtrasShouldIncreasePointsAndResetRescuedPrisionersNumbersWhenCalledWithEmAndamentoState()
        {
            var pontosIniciais = 10;
            var numeroDePrisioneirosSalvos = 2;
            var pontuacaoEsperada = pontosIniciais + 20 + numeroDePrisioneirosSalvos * 10;
            var prisioneirosSalvosEsperados = 0;

            var player = new PlayerBuilder().WithPointsAndRescuedPrisioners(pontosIniciais, numeroDePrisioneirosSalvos).Generate();

            player.GanhaPontosExtras();

            Assert.StrictEqual(pontuacaoEsperada, player.Pontuacao);
            Assert.StrictEqual(prisioneirosSalvosEsperados, player.PrisioneirosSalvos);
        }

        [Fact]
        public void GanhaPontosExtrasShouldIncreasePointsAndResetRescuedPrisionersNumbersWhenCalledWithZeradoState()
        {
            var pontosIniciais = 50;
            var numeroDePrisioneirosSalvos = 3;
            var pontuacaoEsperada = pontosIniciais + 40 + numeroDePrisioneirosSalvos * 30;
            var prisioneirosSalvosEsperados = 0;

            var player = new PlayerBuilder()
                .WithStatePointsAndRescuedPrisioners(new Zerado(), pontosIniciais, numeroDePrisioneirosSalvos)
                .Generate();

            player.GanhaPontosExtras();

            Assert.StrictEqual(pontuacaoEsperada, player.Pontuacao);
            Assert.StrictEqual(prisioneirosSalvosEsperados, player.PrisioneirosSalvos);
        }

        [Fact]
        public void GanhaPontosExtrasShouldThrowAnExceptionWhenCalledWithPerdidoState()
        {
            var pontosIniciais = 10;
            var pontuacaoEsperada = pontosIniciais;
            var player = new PlayerBuilder()
                .WithStateAndPoints(new Perdido(), pontosIniciais)
                .Generate();
            var mensagemEsperada = $"Player {player.Nome} perdeu o game e não pode ganhar mais pontos. Pontuação final: {player.Pontuacao}";

            var exception = Assert.Throws<Exception>(() => player.GanhaPontosExtras());

            Assert.Equal(mensagemEsperada, exception.Message);
        }

        [Fact]
        public void GanhaPontosExtrasShouldThrowAnExceptionWhenCalledWithFinalizadoState()
        {
            var pontosIniciais = 10;
            var pontuacaoEsperada = pontosIniciais;
            var player = new PlayerBuilder()
                .WithStateAndPoints(new Finalizado(), pontosIniciais)
                .Generate();
            var mensagemEsperada = $"Player {player.Nome} finalizou o game e não pode ganhar mais pontos. Pontuação final: {player.Pontuacao}";

            var exception = Assert.Throws<Exception>(() => player.GanhaPontosExtras());

            Assert.Equal(mensagemEsperada, exception.Message);
        }

        [Fact]
        public void ZeraShouldThrowAnExceptionWhenStateIsZerado()
        {
            var player = new PlayerBuilder().WithState(new Zerado()).Generate();
            var mensagemEsperada = $"Player {player.Nome} já zerou o game. Pontuação: {player.Pontuacao}";

            var exception = Assert.Throws<Exception>(() => player.Zera());
            Assert.Equal(mensagemEsperada, exception.Message);
        }

        [Fact]
        public void PerdeShouldThrowAnExceptionWhenStateIsZerado()
        {
            var player = new PlayerBuilder().WithState(new Zerado()).Generate();
            var mensagemEsperada = $"Player {player.Nome} já zerou o game. Pontuação: {player.Pontuacao}";

            var exception = Assert.Throws<Exception>(() => player.Perde());
            Assert.Equal(mensagemEsperada, exception.Message);
        }

        [Fact]
        public void FinalizaShouldCalculateExtraPointsAndSetStateToFinalizadoWhenItIsZerado()
        {
            var pontosIniciais = 10;
            var player = new PlayerBuilder()
                .WithStateAndPoints(new Zerado(), pontosIniciais)
                .Generate();

            var estadoEsperado = new Finalizado().ToString();
            var pontuacaoEsperada = pontosIniciais + 40 + player.PrisioneirosSalvos * 30;

            player.Finaliza();

            Assert.Equal(estadoEsperado, player.EstadoAtual.ToString());
            Assert.Equal(pontuacaoEsperada, player.Pontuacao);
        }

        [Fact]
        public void ZeraShouldThrowAnExceptionWhenStateIsPerdido()
        {
            var player = new PlayerBuilder().WithState(new Perdido()).Generate();
            var mensagemEsperada = $"Player {player.Nome} já perdeu o game. Pontuação final: {player.Pontuacao}";

            var exception = Assert.Throws<Exception>(() => player.Zera());
            Assert.Equal(mensagemEsperada, exception.Message);
        }

        [Fact]
        public void PerdeShouldThrowAnExceptionWhenStateIsPerdido()
        {
            var player = new PlayerBuilder().WithState(new Perdido()).Generate();
            var mensagemEsperada = $"Player {player.Nome} já perdeu o game. Pontuação final: {player.Pontuacao}";

            var exception = Assert.Throws<Exception>(() => player.Zera());
            Assert.Equal(mensagemEsperada, exception.Message);
        }

        [Fact]
        public void FinalizaShouldSetStateToFinalizadoWhenItIsPerdido()
        {
            var estadoEsperado = new Finalizado().ToString();
            var player = new PlayerBuilder().WithState(new Perdido()).Generate();

            player.Finaliza();

            Assert.Equal(estadoEsperado, player.EstadoAtual.ToString());
        }

        [Fact]
        public void ZeraShouldThrowAnExceptionWhenStateIsFinalizado()
        {
            var player = new PlayerBuilder().WithState(new Finalizado()).Generate();
            var mensagemEsperada = $"Player {player.Nome} já finalizou o game. Pontuação final: {player.Pontuacao}";

            var exception = Assert.Throws<Exception>(() => player.Zera());
            Assert.Equal(mensagemEsperada, exception.Message);
        }

        [Fact]
        public void PerdeShouldThrowAnExceptionWhenStateIsFinalizado()
        {
            var player = new PlayerBuilder().WithState(new Finalizado()).Generate();
            var mensagemEsperada = $"Player {player.Nome} já finalizou o game. Pontuação final: {player.Pontuacao}";

            var exception = Assert.Throws<Exception>(() => player.Perde());
            Assert.Equal(mensagemEsperada, exception.Message);
        }

        [Fact]
        public void FinalizaShouldThrowAnExceptionWhenStateIsFinalizado()
        {
            var player = new PlayerBuilder().WithState(new Finalizado()).Generate();
            var mensagemEsperada = $"Player {player.Nome} já finalizou o game. Pontuação final: {player.Pontuacao}";

            var exception = Assert.Throws<Exception>(() => player.Finaliza());
            Assert.Equal(mensagemEsperada, exception.Message);
        }
    }

}
