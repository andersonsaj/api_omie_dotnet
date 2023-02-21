using IntegracaoOmie.Models.Cliente;
using IntegracaoOmie.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntegracaoOmie.Rest.Interface
{
    public interface IClienteRest
    {
        Task<ResponseGenerico<List<ClientesCadastro>>> ListarClientes([FromBody] RequestListarClientes parametros);
        Task<ResponseGenerico<List<ClientesCadastroResumido>>> ListarClientesResumido([FromBody] RequestListarClientes parametros);
    }
}
