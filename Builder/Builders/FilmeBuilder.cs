using PadroesDeProjeto.Builder.Domain.Enums;
using PadroesDeProjeto.Builder.Domain.Models;

namespace PadroesDeProjeto.Builder.Builders
{
    public class FilmeBuilder
    {
        public string Id { get; set; }
        public string? Titulo { get; set; }
        public int Ano { get; set; }
        public Genero Genero { get; set; }
        public bool EmCartaz { get; set; }

        private IList<string> Diretores = new List<string>();
        private IList<string> Elenco = new List<string>();

        public FilmeBuilder()
        {
            Id = new Guid().ToString();
        }

        public Filme Constroi()
        {
            return new Filme(Id, Titulo, Diretores, Ano, Elenco, Genero, EmCartaz);
        }

        public FilmeBuilder ComId(string id)
        {
            Id = id;
            return this;
        }

        public FilmeBuilder ComTitulo(string titulo)
        {
            Titulo = titulo;
            return this;
        }

        public FilmeBuilder ComAno(int ano)
        {
            Ano = ano;
            return this;
        }

        public FilmeBuilder ComGenero(Genero genero)
        {
            Genero = genero;
            return this;
        }

        public FilmeBuilder ComEmCartaz(bool emCartaz)
        {
            EmCartaz = emCartaz;
            return this;
        }

        public FilmeBuilder ComDiretores(IList<string> diretores)
        {
            Diretores = diretores;
            return this;
        }

        public FilmeBuilder ComElenco(IList<string> elenco)
        {
            Elenco = elenco;
            return this;
        }
    }
}
