using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Locacao
    {
        public int DiasDeLocacao { get; private set; }
        public string NomeLivro { get; private set; }
        public double ValorFixo { get; private set; }

        public Locacao(string _nomeLivro, int _diasDeLocacao)
        {
            DiasDeLocacao = _diasDeLocacao;
            NomeLivro = _nomeLivro;
            ValorFixo = 20.00;
        }
        
    }
}
