namespace PadroesDeProjeto.ChainOfResponsability;

public class Helper
{
    public Helper(){}

    public bool Existe(String nomeDoItem, Venda venda)
    {
        foreach (Item item in venda.Itens)
        {
            if (item.Nome.Equals(nomeDoItem))
                return true;
        }
        return false;
    }
}