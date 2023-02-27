namespace PadroesDeProjeto.ChainOfResponsability;

public class Venda
{
    public double Valor { get; private set; }
    public IList<Item> Itens { get; private set; }

    public Venda()
    {
        this.Valor = 0;
        this.Itens = new List<Item>();
    }

    public void AdicionaItem(Item item)
    {
        Itens.Add(item);
        Valor = this.Valor + item.Valor;
    }
}