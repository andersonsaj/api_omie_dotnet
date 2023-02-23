using FluentValidation;
using IntegracaoOmie.Models;
using IntegracaoOmie.Models.Cliente;
using IntegracaoOmie.Models.ContaCorrente;
using IntegracaoOmie.Rest.Interfaces;
using IntegracaoOmie.Services.Interfaces;
using IntegracaoOmie.Validator.Cliente;
using IntegracaoOmie.Validator.ContaCorrente;
using System.Dynamic;

namespace IntegracaoOmie.Services;

public class ContaCorrenteServices : IContaCorrenteServices
{
    private readonly IContaCorrenteRest _contaCorrenteRest;
    private readonly RequestBase _requestBase;

    public ContaCorrenteServices(IContaCorrenteRest contaCorrenteRest, RequestBase requestBase)
    {
        _contaCorrenteRest = contaCorrenteRest;
        _requestBase = requestBase;
    }

    public async Task<ResponseGenerico<ResponseConsultarContaCorrente>> ConsultarContaCorrente(ConsultarContaCorrente parametros)
    {
        if (parametros.NCodCC == 0 && String.IsNullOrWhiteSpace(parametros.NCodCCIntegracao))
        {
            dynamic obj = new ExpandoObject();
            obj.mensagens = "Informe um parametro";
            return new ResponseGenerico<ResponseConsultarContaCorrente>
            {
                CodigoHttp = System.Net.HttpStatusCode.BadRequest,
                ErroRetorno = obj
            };
        }

        var contaCorrente = new RequestConsultarContaCorrente()
        {
            call = "ConsultarContaCorrente",
            app_key = _requestBase.app_key,
            app_secret = _requestBase.app_secret,
        };

        contaCorrente.Params.Add(parametros);

        return await _contaCorrenteRest.ConsultarContaCorrente(contaCorrente);

    }

    public async Task<ResponseGenerico<ResponseIncluirContaCorrente>> IncluirContaCorrente(IncluirContaCorrente parametros)
    {
        var validator = new ContaCorrenteCadastroValidator();

        var resultado = validator.Validate(parametros);

        if (!resultado.IsValid)
        {
            var mensagensErro = resultado.Errors.Select(error => error.ErrorMessage).ToList();

            dynamic obj = new ExpandoObject();
            obj.mensagens = mensagensErro;
            return new ResponseGenerico<ResponseIncluirContaCorrente>
            {
                CodigoHttp = System.Net.HttpStatusCode.BadRequest,
                ErroRetorno = obj
            };
        }

        var contaCorrente = new RequestIncluirContaCorrente()
        {
            call = "IncluirContaCorrente",
            app_key = _requestBase.app_key,
            app_secret = _requestBase.app_secret,
        };

        contaCorrente.Params.Add(parametros);

        return await _contaCorrenteRest.IncluirContaCorrente(contaCorrente);
    }

    public async Task<ResponseGenerico<List<ListarContasCorrentes>>> ListarContasCorrentes()
    {
        var listContasCorrentes = new RequestListar
        {
            call = "ListarContasCorrentes",
            app_key = _requestBase.app_key,
            app_secret = _requestBase.app_secret,
        };


        listContasCorrentes.Params.Add(new Param());

        return await _contaCorrenteRest.ListarContasCorrentes(listContasCorrentes);
    }
}
