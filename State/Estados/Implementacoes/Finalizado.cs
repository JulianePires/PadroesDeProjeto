namespace PadroesDeProjeto.State.Estados.Implementacoes
{
    public class Finalizado : IEstadosDoPlayer
    {
        public void GanhaPontosExtras(Player player)
        {
            throw new Exception($"Player {player.Nome} finalizou o game e não pode ganhar mais pontos. Pontuação final: {player.Pontuacao}");
        }

        public void Zera(Player player)
        {
            throw new Exception($"Player {player.Nome} já finalizou o game. Pontuação final: {player.Pontuacao}");
        }

        public void Perde(Player player)
        {
            throw new Exception($"Player {player.Nome} já finalizou o game. Pontuação final: {player.Pontuacao}");
        }

        public void Finaliza(Player player)
        {
            throw new Exception($"Player {player.Nome} já finalizou o game. Pontuação final: {player.Pontuacao}");
        }

        public void SalvaPrisioneiro(Player player)
        {
            throw new Exception($"Player {player.Nome} já finalizou o game, não pode salvar mais prisioneiros.");
        }
    }
}
