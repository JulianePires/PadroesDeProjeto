using PadroesDeProjeto.TemplateMethod;
using PadroesDeProjeto.TemplateMethod.Enums;
using PadroesDeProjeto.TemplateMethod.Implementacoes;

namespace PadroesDeProjeto.Tests.TemplateMethod;

public class RespostaRequisicaoTest
{
    BuscaObjeto buscaObjeto = new();
    CriaObjeto criaObjeto = new();
    AtualizaObjeto atualizaObjeto = new();
    DeletaObjeto deletaObjeto  = new();


    [Fact]
    public void BuscaObjetoDeveRetornarMensagemDeSucessoSeRequisicaoDoTipoGetEStatusCodeFound()
    {
        Requisicao requisicao = new(MetodosRequisicao.Get, StatusCodes.Found);
        var respostaEsperada = "O objeto foi encontrado";
        
        var resposta = buscaObjeto.TrataResposta(requisicao);

        Assert.Equal(respostaEsperada, resposta);
    }

    [Fact]
    public void BuscaObjetoDeveRetornarMensagemDeErroSeRequisicaoDoTipoGetEStatusCodeNotFound()
    {
        Requisicao requisicao = new(MetodosRequisicao.Get, StatusCodes.NotFound);
        var respostaEsperada = "O objeto não foi encontrado";

        var resposta = buscaObjeto.TrataResposta(requisicao);

        Assert.Equal(respostaEsperada, resposta);
    }

    [Fact]
    public void CriaObjetoDeveRetornarMensagemDeSucessoSeRequisicaoDoTipoPosttEStatusCodeCreated()
    {
        Requisicao requisicao = new(MetodosRequisicao.Post, StatusCodes.Created);
        var respostaEsperada = "O objeto foi criado com sucesso";

        var resposta = criaObjeto.TrataResposta(requisicao);

        Assert.Equal(respostaEsperada, resposta);
    }

    [Fact]
    public void BuscaObjetoDeveRetornarMensagemDeErroSeRequisicaoDoTipoPostEStatusCodeBadRequest()
    {
        Requisicao requisicao = new(MetodosRequisicao.Post, StatusCodes.BadRequest);
        var respostaEsperada = "O objeto não pôde ser criado";

        var resposta = criaObjeto.TrataResposta(requisicao);

        Assert.Equal(respostaEsperada, resposta);
    }

    [Fact]
    public void AtualizaObjetoDeveRetornarMensagemDeSucessoSeRequisicaoDoTipoPatchEStatusCodeOk()
    {
        Requisicao requisicao = new(MetodosRequisicao.Patch, StatusCodes.Ok);
        var respostaEsperada = "O objeto foi atualizado com sucesso";

        var resposta = atualizaObjeto.TrataResposta(requisicao);

        Assert.Equal(respostaEsperada, resposta);
    }

    [Fact]
    public void BuscaObjetoDeveRetornarMensagemDeErroSeRequisicaoDoTipoPatchEStatusCodeBadRequest()
    {
        Requisicao requisicao = new(MetodosRequisicao.Patch, StatusCodes.BadRequest);
        var respostaEsperada = "O objeto não pôde ser atualizado";

        var resposta = atualizaObjeto.TrataResposta(requisicao);

        Assert.Equal(respostaEsperada, resposta);
    }

    [Fact]
    public void DeletaObjetoDeveRetornarMensagemDeSucessoSeRequisicaoDoTipoDeletehEStatusCodeOk()
    {
        Requisicao requisicao = new(MetodosRequisicao.Delete, StatusCodes.Ok);
        var respostaEsperada = "O objeto foi deletetado com sucesso";

        var resposta = deletaObjeto.TrataResposta(requisicao);

        Assert.Equal(respostaEsperada, resposta);
    }

    [Fact]
    public void DeletaObjetoDeveRetornarMensagemDeErroSeRequisicaoDoTipoDeleteEStatusCodeBadRequest()
    {
        Requisicao requisicao = new(MetodosRequisicao.Delete, StatusCodes.BadRequest);
        var respostaEsperada = "O objeto não pôde ser deletado";

        var resposta = deletaObjeto.TrataResposta(requisicao);

        Assert.Equal(respostaEsperada, resposta);
    }
}