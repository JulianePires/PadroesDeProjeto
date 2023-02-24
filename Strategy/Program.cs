// See https://aka.ms/new-console-template for more information

using Strategy;
using Strategy.Faixas;

Locacao locacao = new Locacao("Um livro", 2);
IFaixaDeCalculo faixaAzul = new FaixaAzul();
IFaixaDeCalculo faixaAmarela = new FaixaAmarela();
IFaixaDeCalculo faixaVerde = new FaixaVerde();
IFaixaDeCalculo faixaBranca = new FaixaBranca();

CalculadoraDeLocacao calculadora = new CalculadoraDeLocacao();

var valorLocacaoAzul = calculadora.RealizaLocacao(locacao, faixaAzul);
var valorLocacaoAmarela = calculadora.RealizaLocacao(locacao, faixaAmarela);
var valorLocacaoVerde = calculadora.RealizaLocacao(locacao, faixaVerde);
var valorLocacaoBranca = calculadora.RealizaLocacao(locacao, faixaBranca);

Console.WriteLine("Locação Azul: "+valorLocacaoAzul);
Console.WriteLine("Locação Amarela: " + valorLocacaoAmarela);
Console.WriteLine("Locação Verde: " + valorLocacaoVerde);
Console.WriteLine("Locação Branca: " + valorLocacaoBranca);
