using PadroesDeProjeto.State.Estados;
using PadroesDeProjeto.State.Estados.Implementacoes;
namespace PadroesDeProjeto.State
{
    public class Player
    {
        //TODO: Implementar métodos padrão
        //TODO: Implementar testes
        public string Nome { get; set; }
        public double Pontuacao { get; set; }
        private EstadosDoPlayer _estadoAtual { get; set; }

        public Player(string nome, double pontuacao)
        {
            Nome = nome;
            Pontuacao = pontuacao;
            _estadoAtual = new EmAndamento();
        }

        public void GanhaPontosExtras()
        {

        }

        public void Zera()
        {

        }

        public void Perde()
        {

        }

        public void Finaliza()
        {

        }
    }
}
