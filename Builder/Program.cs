// See https://aka.ms/new-console-template for more information
using PadroesDeProjeto.Builder.Builders;
using PadroesDeProjeto.Builder.Domain.Enums;

var filme = new FilmeBuilder()
    .ComTitulo("La noche de 12 años")
    .ComAno(2018)
    .ComDiretores(new List<string>() { "Álvaro Brechner" })
    .ComElenco(new List<string>() { "Antonio De La Torre", "Chino Darín", "Alfonso Tort" })
    .ComGenero(Genero.Aventura)
    .ComEmCartaz(false)
    .Constroi();
