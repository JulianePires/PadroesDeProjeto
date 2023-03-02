// See https://aka.ms/new-console-template for more information

using PadroesDeProjeto.TemplateMethod;
using PadroesDeProjeto.TemplateMethod.Enums;
using PadroesDeProjeto.TemplateMethod.Implementacoes;

Requisicao requisicao = new(MetodosRequisicao.Get, StatusCodes.NotFound);

BuscaObjeto buscaObjeto = new();

var resposta = buscaObjeto.TrataResposta(requisicao);

Console.WriteLine(resposta);

