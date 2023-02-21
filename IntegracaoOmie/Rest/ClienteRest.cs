using IntegracaoOmie.Models;
using IntegracaoOmie.Models.Cliente;
using IntegracaoOmie.Rest.Interface;
using Newtonsoft.Json;
using RestSharp;
using System.Dynamic;
using System.Net;

namespace IntegracaoOmie.Rest;

public class ClienteRest : IClienteRest
{
    private readonly string _url = "https://app.omie.com.br/api/v1/geral/clientes/";
    public async Task<ResponseGenerico<List<ClientesCadastroResumido>>> ListarClientesResumido(RequestListarClientes parametros)
    {
        var response = new ResponseGenerico<List<ClientesCadastroResumido>>();
        var respContent = new RestResponse();
        try
        {
            var request = new RestRequest();
            request.AddBody(parametros);
            request.AddHeader("Content-Type", "application/json");

            using (var cliente = new RestClient(_url))
            {
                respContent = await cliente.PostAsync(request);

                if (respContent.IsSuccessStatusCode)
                {
                    var objResponse = JsonConvert.DeserializeObject<ResponseClientesCadastroResumido>(respContent.Content);
                    var pagina = objResponse.Pagina;
                    var totalPaginas = objResponse.TotalDePaginas;

                    response.CodigoHttp = respContent.StatusCode;
                    response.DadosRetorno = objResponse.clientes.ToList();
                    while (pagina < totalPaginas)
                    {
                        pagina++;

                        parametros.param[0].pagina = pagina;
                        request.AddBody(parametros);

                        try
                        {
                            respContent = await cliente.PostAsync(request);
                            objResponse = JsonConvert.DeserializeObject<ResponseClientesCadastroResumido>(respContent.Content);
                            response.DadosRetorno.AddRange(objResponse.clientes);
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
            response.CodigoHttp = HttpStatusCode.InternalServerError;
        }

        return response;
    }

    public async Task<ResponseGenerico<List<ClientesCadastro>>> ListarClientes(RequestListarClientes parametros)
    {
        var response = new ResponseGenerico<List<ClientesCadastro>>();
        var respContent = new RestResponse();
        try
        {
            var request = new RestRequest();
            request.AddBody(parametros);
            request.AddHeader("Content-Type", "application/json");

            using (var cliente = new RestClient(_url))
            {
                respContent = await cliente.PostAsync(request);

                if (respContent.IsSuccessStatusCode)
                {
                    var objResponse = JsonConvert.DeserializeObject<ResponseListarClientes>(respContent.Content);
                    var pagina = objResponse.Pagina;
                    var totalPaginas = objResponse.TotalDePaginas;

                    response.CodigoHttp = respContent.StatusCode;
                    response.DadosRetorno = objResponse.ClientesCadastro.ToList();
                    while (pagina < totalPaginas)
                    {
                        pagina++;

                        parametros.param[0].pagina = pagina;
                        request.AddBody(parametros);

                        try
                        {
                            respContent = await cliente.PostAsync(request);
                            objResponse = JsonConvert.DeserializeObject<ResponseListarClientes>(respContent.Content);
                            response.DadosRetorno.AddRange(objResponse.ClientesCadastro);
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
            response.CodigoHttp = HttpStatusCode.InternalServerError;
        }

        return response;
    }
}
