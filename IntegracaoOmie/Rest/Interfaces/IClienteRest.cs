using IntegracaoOmie.Models.Cliente;
using IntegracaoOmie.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntegracaoOmie.Rest.Interface
{
    public interface IClienteRest
    {
        Task<ResponseGenerico<List<ClienteCadastroCompleto>>> ListarClientes(RequestListarClientes parametros);

        Task<ResponseGenerico<List<ClienteCadastroResumido>>> ListarClientesResumido(RequestListarClientes parametros);

        Task<ResponseGenerico<ResponseClienteCadastro>> IncluirCliente(RequestCadastrarCliente parametros);

        Task<ResponseGenerico<string>> IncluirClientesPorLote(RequestCadastrarClienteLote parametros);
    }
}
