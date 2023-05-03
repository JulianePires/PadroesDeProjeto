// See https://aka.ms/new-console-template for more information
using PadroesDeProjeto.State;

Player player = new("Maria Silva", 50);

player.GanhaPontosExtras();

player.SalvaPrisioneiro();
player.SalvaPrisioneiro();

player.GanhaPontosExtras();

player.Zera();

player.GanhaPontosExtras();

player.Finaliza();

player.GanhaPontosExtras();

player.Perde();

player.Zera();

Console.WriteLine($"Player: {player.Nome} | Prisioneiros Salvos: {player.PrisioneirosSalvos} | Pontuação: {player.Pontuacao}");
