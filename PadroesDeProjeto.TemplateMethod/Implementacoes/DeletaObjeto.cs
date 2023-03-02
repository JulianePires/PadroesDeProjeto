using PadroesDeProjeto.TemplateMethod.Enums;

namespace PadroesDeProjeto.TemplateMethod.Implementacoes;

public class DeletaObjeto : RespostaRequisicao
{
    protected override bool StatusCodeSucesso(Requisicao requisicao)
    {
        return requisicao.Metodo == MetodosRequisicao.Delete && requisicao.Status == StatusCodes.Ok;
    }

    protected override string RespostaSucesso()
    {
        return "O objeto foi deletetado com sucesso";
    }

    protected override string RespostaErro()
    {
        return "O objeto não pôde ser deletado";
    }
}