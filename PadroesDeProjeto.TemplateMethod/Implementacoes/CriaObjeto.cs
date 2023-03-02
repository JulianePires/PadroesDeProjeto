using PadroesDeProjeto.TemplateMethod.Enums;

namespace PadroesDeProjeto.TemplateMethod.Implementacoes;

public class CriaObjeto : RespostaRequisicao
{
    protected override bool StatusCodeSucesso(Requisicao requisicao)
    {
        return requisicao.Metodo == MetodosRequisicao.Post && requisicao.Status == StatusCodes.Created;
    }

    protected override string RespostaSucesso()
    {
        return "O objeto foi criado com sucesso";
    }

    protected override string RespostaErro()
    {
        return "O objeto não pôde ser criado";
    }
}