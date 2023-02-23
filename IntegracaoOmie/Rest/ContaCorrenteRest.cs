using IntegracaoOmie.Models;
using IntegracaoOmie.Models.Cliente;
using IntegracaoOmie.Models.ContaCorrente;
using IntegracaoOmie.Rest.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using System.Dynamic;
using System.Net;

namespace IntegracaoOmie.Rest;

public class ContaCorrenteRest : IContaCorrenteRest
{
    private readonly string _url = "https://app.omie.com.br/api/v1/geral/contacorrente/";

    public async Task<ResponseGenerico<ResponseConsultarContaCorrente>> ConsultarContaCorrente(RequestConsultarContaCorrente parametros)
    {
        var response = new ResponseGenerico<ResponseConsultarContaCorrente>();
        var request = new RestRequest();
        request.AddBody(JsonConvert.SerializeObject(parametros));
        request.AddHeader("Content-Type", "application/json");
        try
        {
            var respContent = new RestResponse();
            using (var cliente = new RestClient(_url))
            {
                respContent = await cliente.PostAsync(request);

                if (respContent.IsSuccessStatusCode)
                {
                    response.CodigoHttp = respContent.StatusCode;
                    response.DadosRetorno = JsonConvert.DeserializeObject<ResponseConsultarContaCorrente>(respContent.Content); ;
                }
                else
                {
                    response.CodigoHttp = respContent.StatusCode;
                    response.ErroRetorno = JsonConvert.DeserializeObject<ExpandoObject>(respContent.Content);
                }

            }
        }
        catch (Exception e)
        {
            dynamic obj = new ExpandoObject();
            obj.mensagens = e.Message;
            response.CodigoHttp = HttpStatusCode.InternalServerError;
            response.ErroRetorno = obj.mensagens;
        }

        return response;
    }

    public async Task<ResponseGenerico<ResponseIncluirContaCorrente>> IncluirContaCorrente(RequestIncluirContaCorrente parametros)
    {
        var response = new ResponseGenerico<ResponseIncluirContaCorrente>();
        var request = new RestRequest();
        request.AddBody(JsonConvert.SerializeObject(parametros));
        request.AddHeader("Content-Type", "application/json");
        try
        {
            var respContent = new RestResponse();
            using (var cliente = new RestClient(_url))
            {
                respContent = await cliente.PostAsync(request);

                if (respContent.IsSuccessStatusCode)
                {
                    response.CodigoHttp = respContent.StatusCode;
                    response.DadosRetorno = JsonConvert.DeserializeObject<ResponseIncluirContaCorrente>(respContent.Content); ;
                }
                else
                {
                    response.CodigoHttp = respContent.StatusCode;
                    response.ErroRetorno = JsonConvert.DeserializeObject<ExpandoObject>(respContent.Content);
                }

            }
        }
        catch (Exception e)
        {
            dynamic obj = new ExpandoObject();
            obj.mensagens = e.Message;
            response.CodigoHttp = HttpStatusCode.InternalServerError;
            response.ErroRetorno = obj.mensagens;
        }

        return response;
    }

    public async Task<ResponseGenerico<List<ListarContasCorrentes>>> ListarContasCorrentes(RequestListar parametros)
    {
        var response = new ResponseGenerico<List<ListarContasCorrentes>>();
        try
        {
            var respContent = new RestResponse();
            var request = new RestRequest();
            request.AddBody(JsonConvert.SerializeObject(parametros));
            request.AddHeader("Content-Type", "application/json");

            using (var cliente = new RestClient(_url))
            {
                respContent = await cliente.PostAsync(request);

                if (respContent.IsSuccessStatusCode)
                {
                    var objResponse = JsonConvert.DeserializeObject<ResponseListarContasCorrentes>(respContent.Content);
                    var pagina = objResponse.Pagina;
                    var totalPaginas = objResponse.TotalDePaginas;

                    response.CodigoHttp = respContent.StatusCode;
                    response.DadosRetorno = objResponse.ListarContasCorrentes.ToList();
                    while (pagina < totalPaginas)
                    {
                        pagina++;

                        parametros.Params[0].pagina = pagina;
                        request.AddBody(parametros);

                        try
                        {
                            respContent = await cliente.PostAsync(request);
                            objResponse = JsonConvert.DeserializeObject<ResponseListarContasCorrentes>(respContent.Content);
                            response.DadosRetorno.AddRange(objResponse.ListarContasCorrentes);
                        }
                        catch
                        {
                            Thread.Sleep(10000);
                            pagina--;
                        }
                    }
                }
                else
                {
                    response.CodigoHttp = respContent.StatusCode;
                    response.ErroRetorno = JsonConvert.DeserializeObject<ExpandoObject>(respContent.Content);
                }
            }
        }
        catch (Exception e)
        {
            dynamic obj = new ExpandoObject();
            obj.mensagens = e.Message;
            response.CodigoHttp = HttpStatusCode.InternalServerError;
            response.ErroRetorno = obj.mensagens;
        }

        return response;
    }
}
