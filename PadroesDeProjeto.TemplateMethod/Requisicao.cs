using PadroesDeProjeto.TemplateMethod.Enums;

namespace PadroesDeProjeto.TemplateMethod;

public class Requisicao
{
    public MetodosRequisicao Metodo { get; private set; }
    public StatusCodes Status { get; private set; }

    public Requisicao(MetodosRequisicao _metodo, StatusCodes _status)
    {
        Metodo = _metodo;
        Status = _status;
    }
}