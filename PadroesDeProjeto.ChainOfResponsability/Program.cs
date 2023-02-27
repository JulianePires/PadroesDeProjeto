// See https://aka.ms/new-console-template for more information

using PadroesDeProjeto.ChainOfResponsability;

CorrenteDeDescontos corrente = new();

Venda venda = new();

Item cebola = new Item("Cebola", 2.5);
Item tomate = new Item("Tomate", 3.5);
Item molhoDeTomate = new Item("Molho de Tomate", 4.0);
Item xampu = new Item("Xampu", 12.00);
Item macarrao = new Item("Macarrao", 3.0);
Item pao = new Item("Pao", 4.0);

venda.AdicionaItem(cebola);
venda.AdicionaItem(cebola);
venda.AdicionaItem(molhoDeTomate);
venda.AdicionaItem(tomate);
venda.AdicionaItem(xampu);
venda.AdicionaItem(pao);

Console.WriteLine(venda.Valor);

