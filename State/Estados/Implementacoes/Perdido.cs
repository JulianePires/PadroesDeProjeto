namespace PadroesDeProjeto.State.Estados.Implementacoes
{
    public class Perdido : IEstadosDoPlayer
    {
        public void GanhaPontosExtras(Player player)
        {
            throw new Exception($"Player {player.Nome} perdeu o game e não pode ganhar mais pontos. Pontuação final: {player.Pontuacao}");
        }

        public void Zera(Player player)
        {
            throw new Exception($"Player {player.Nome} já perdeu o game. Pontuação final: {player.Pontuacao}");
        }

        public void Perde(Player player)
        {
            throw new Exception($"Player {player.Nome} já perdeu o game. Pontuação final: {player.Pontuacao}");
        }

        public void Finaliza(Player player)
        {
            player.EstadoAtual = new Finalizado();
            Console.WriteLine($"Player {player.Nome} encerrou o game. Pontuação: ${player.Pontuacao}");
        }

        public void SalvaPrisioneiro(Player player)
        {
            throw new Exception($"Player {player.Nome} já perdeu o game, não pode salvar mais prisioneiros.");
        }
    }
}
