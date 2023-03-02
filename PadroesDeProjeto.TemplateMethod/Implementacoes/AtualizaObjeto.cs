using PadroesDeProjeto.TemplateMethod.Enums;

namespace PadroesDeProjeto.TemplateMethod.Implementacoes;

public class AtualizaObjeto : RespostaRequisicao
{
    protected override bool StatusCodeSucesso(Requisicao requisicao)
    {
        return requisicao.Metodo == MetodosRequisicao.Patch && requisicao.Status == StatusCodes.Ok;
    }

    protected override string RespostaSucesso()
    {
        return "O objeto foi atualizado com sucesso";
    }

    protected override string RespostaErro()
    {
        return "O objeto não pôde ser atualizado";
    }
}