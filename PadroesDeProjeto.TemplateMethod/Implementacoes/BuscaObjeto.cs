using PadroesDeProjeto.TemplateMethod.Enums;

namespace PadroesDeProjeto.TemplateMethod.Implementacoes;

public class BuscaObjeto : RespostaRequisicao
{
    protected override bool StatusCodeSucesso(Requisicao requisicao)
    {
        return requisicao.Metodo == MetodosRequisicao.Get && requisicao.Status == StatusCodes.Found;
    }

    protected override string RespostaSucesso()
    {
        return "O objeto foi encontrado";
    }

    protected override string RespostaErro()
    {
        return "O objeto não foi encontrado";
    }
}