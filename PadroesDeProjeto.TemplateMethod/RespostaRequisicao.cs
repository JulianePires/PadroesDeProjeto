namespace PadroesDeProjeto.TemplateMethod;

public abstract class RespostaRequisicao
{
    public string TrataResposta(Requisicao requisicao)
    {
        if (StatusCodeSucesso(requisicao))
        {
            return RespostaSucesso();
        }

        return RespostaErro();
    }

    protected abstract bool StatusCodeSucesso(Requisicao requisicao);
    protected abstract string RespostaSucesso();
    protected abstract string RespostaErro();
}