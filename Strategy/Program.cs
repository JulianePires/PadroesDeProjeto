// See https://aka.ms/new-console-template for more information

using Strategy;
using Strategy.Faixas;

var tempoDeLocacao = TimeSpan.FromDays(2);
IFaixaDeCalculo faixaAzul = new FaixaAzul();
IFaixaDeCalculo faixaAmarela = new FaixaAmarela();
IFaixaDeCalculo faixaVerde = new FaixaVerde();
IFaixaDeCalculo faixaBranca = new FaixaBranca();

CalculadoraDeLocacao calculadora = new CalculadoraDeLocacao();

var valorLocacaoAzul = calculadora.RealizaLocacao(tempoDeLocacao, faixaAzul);
var valorLocacaoAmarela = calculadora.RealizaLocacao(tempoDeLocacao, faixaAmarela);
var valorLocacaoVerde = calculadora.RealizaLocacao(tempoDeLocacao, faixaVerde);
var valorLocacaoBranca = calculadora.RealizaLocacao(tempoDeLocacao, faixaBranca);

Console.WriteLine("Locação Azul: "+valorLocacaoAzul);
Console.WriteLine("Locação Amarela: " + valorLocacaoAmarela);
Console.WriteLine("Locação Verde: " + valorLocacaoVerde);
Console.WriteLine("Locação Branca: " + valorLocacaoBranca);
