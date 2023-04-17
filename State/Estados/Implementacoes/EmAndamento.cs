namespace PadroesDeProjeto.State.Estados.Implementacoes
{
    public class EmAndamento : IEstadosDoPlayer
    {
        public void GanhaPontosExtras(Player player)
        {
            player.Pontuacao += 20 + player.PrisioneirosSalvos * 10;
            Console.WriteLine($"Você ganhou pontos extras! Prisioneiros salvos: {player.PrisioneirosSalvos} | Seus prisioneiros serão zerados.");
            player.PrisioneirosSalvos = 0;
        }

        public void Zera(Player player)
        {
            GanhaPontosExtras(player);
            player.EstadoAtual = new Zerado();
            Console.WriteLine($"Parabéns {player.Nome}, você zerou o game! Pontuação: {player.Pontuacao}");
        }

        public void Perde(Player player)
        {
            GanhaPontosExtras(player);
            player.EstadoAtual = new Perdido();
            Console.WriteLine($"Que pena {player.Nome}, você perdeu! Pontuação: {player.Pontuacao}");
        }

        public void Finaliza(Player player)
        {
            GanhaPontosExtras(player);
            player.EstadoAtual = new Finalizado();
            Console.WriteLine($"Player {player.Nome} encerrou o game. Pontuação: ${player.Pontuacao}");
        }

        public void SalvaPrisioneiro(Player player)
        {
            player.PrisioneirosSalvos++;
            Console.WriteLine($"Você salvou um prisioneiro. Prisioneiros salvos: {player.PrisioneirosSalvos}");
        }
    }
}
