using PadroesDeProjeto.Builder.Domain.Enums;

namespace PadroesDeProjeto.Builder.Domain.Models
{
    public class Filme
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public IList<string> Diretores { get; set; }
        public int Ano { get; set; }
        public IList<string> Elenco { get; set; }
        public Genero Genero { get; set; }
        public bool EmCartaz { get; set; }

        public Filme(string id, string titulo, IList<string> diretores, int ano, IList<string> elenco, Genero genero, bool emCartaz)
        {
            Id = id;
            Titulo = titulo;
            Diretores = diretores;
            Ano = ano;
            Elenco = elenco;
            Genero = genero;
            EmCartaz = emCartaz;
        }
    }
}
