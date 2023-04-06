using AutoBogus;
using PadroesDeProjeto.State;
using PadroesDeProjeto.State.Estados;
using PadroesDeProjeto.State.Estados.Implementacoes;

namespace PadroesDeProjeto.Tests.Helpers.Builders.State
{
    public class PlayerBuilder : AutoFaker<Player>
    {
        public PlayerBuilder()
        {
            RuleFor(x => x.Nome, "Maria Silva");
            RuleFor(x => x.Pontuacao, 30);
            RuleFor(x => x.PrisioneirosSalvos, 0);
            RuleFor(x => x.EstadoAtual, new EmAndamento());
        }

        public PlayerBuilder WithInitialPoints(double pontuacao)
        {
            RuleFor(x => x.Nome, "Maria Silva");
            RuleFor(x => x.PrisioneirosSalvos, 0);
            RuleFor(x => x.Pontuacao, pontuacao);
            RuleFor(x => x.EstadoAtual, new EmAndamento());

            return this;
        }

        public PlayerBuilder WithPointsAndRescuedPrisioners(double pontuacao, int prisioneiros)
        {
            RuleFor(x => x.Nome, "Maria Silva");
            RuleFor(x => x.Pontuacao, pontuacao);
            RuleFor(x => x.PrisioneirosSalvos, prisioneiros);
            RuleFor(x => x.EstadoAtual, new EmAndamento());

            return this;
        }

        public PlayerBuilder WithRescuedPrisioners(int prisioneiros)
        {
            RuleFor(x => x.Nome, "Maria Silva");
            RuleFor(x => x.Pontuacao, 30);
            RuleFor(x => x.PrisioneirosSalvos, prisioneiros);
            RuleFor(x => x.EstadoAtual, new EmAndamento());

            return this;
        }

        public PlayerBuilder WithState(IEstadosDoPlayer estado)
        {
            RuleFor(x => x.Nome, "Maria Silva");
            RuleFor(x => x.Pontuacao, 30);
            RuleFor(x => x.PrisioneirosSalvos, 0);
            RuleFor(x => x.EstadoAtual, estado);

            return this;
        }

        public PlayerBuilder WithStateAndRescuedPrisioners(IEstadosDoPlayer estado, int prisioneiros)
        {
            RuleFor(x => x.Nome, "Maria Silva");
            RuleFor(x => x.Pontuacao, 30);
            RuleFor(x => x.PrisioneirosSalvos, prisioneiros);
            RuleFor(x => x.EstadoAtual, estado);

            return this;
        }

        public PlayerBuilder WithStateAndPoints(IEstadosDoPlayer estado, double pontos)
        {
            RuleFor(x => x.Nome, "Maria Silva");
            RuleFor(x => x.Pontuacao, pontos);
            RuleFor(x => x.PrisioneirosSalvos, 0);
            RuleFor(x => x.EstadoAtual, estado);

            return this;
        }

        public PlayerBuilder WithStatePointsAndRescuedPrisioners(IEstadosDoPlayer estado, double points, int prisioneiros)
        {
            RuleFor(x => x.Nome, "Maria Silva");
            RuleFor(x => x.Pontuacao, points);
            RuleFor(x => x.PrisioneirosSalvos, prisioneiros);
            RuleFor(x => x.EstadoAtual, estado);

            return this;
        }
    }
}
