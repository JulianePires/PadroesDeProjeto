namespace PadroesDeProjeto.State.Estados.Implementacoes
{
    public class Zerado : IEstadosDoPlayer
    {
        public void GanhaPontosExtras(Player player)
        {
            player.Pontuacao += 40 + player.PrisioneirosSalvos * 30;
            Console.WriteLine($"Você ganhou pontos extras! Prisioneiros salvos: {player.PrisioneirosSalvos} | Seus prisioneiros serão zerados.");
            player.PrisioneirosSalvos = 0;
        }

        public void Zera(Player player)
        {
            throw new Exception($"Player {player.Nome} já zerou o game. Pontuação: ${player.Pontuacao}");
        }

        public void Perde(Player player)
        {
            throw new Exception($"Player {player.Nome} já zerou o game. Pontuação: ${player.Pontuacao}");
        }

        public void Finaliza(Player player)
        {
            GanhaPontosExtras(player);
            player.EstadoAtual = new Finalizado();
            Console.WriteLine($"Player {player.Nome} encerrou o game. Pontuação final: {player.Pontuacao}");
        }

        public void SalvaPrisioneiro(Player player)
        {
            throw new Exception($"Player {player.Nome} já zerou o game, não pode salvar mais prisioneiros.");
        }
    }
}
