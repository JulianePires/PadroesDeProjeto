using PadroesDeProjeto.State.Estados;
using PadroesDeProjeto.State.Estados.Implementacoes;
namespace PadroesDeProjeto.State
{
    public class Player
    {
        //TODO: Implementar testes
        public string Nome { get; set; }
        public double Pontuacao { get; set; }
        public int PrisioneirosSalvos { get; set; }
        public IEstadosDoPlayer EstadoAtual { get; set; }

        public Player(string nome, double pontuacao)
        {
            Nome = nome;
            Pontuacao = pontuacao;
            PrisioneirosSalvos = 0;
            EstadoAtual = new EmAndamento();
        }

        public void SalvaPrisioneiro()
        {
            EstadoAtual.SalvaPrisioneiro(this);
        }

        public void GanhaPontosExtras()
        {
            EstadoAtual.GanhaPontosExtras(this);
        }

        public void Zera()
        {
            EstadoAtual.Zera(this);
        }

        public void Perde()
        {
            EstadoAtual.Perde(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
