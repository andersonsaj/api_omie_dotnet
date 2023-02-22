using IntegracaoOmie.Models.Cliente;
using IntegracaoOmie.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntegracaoOmie.Services.Interfaces
{
    public interface IClienteServices
    {
        public Task<ResponseGenerico<List<ClienteCadastroResumido>>> ListarClientesResumido();

        public Task<ResponseGenerico<List<ClienteCadastroCompleto>>> ListarClientes();

        Task<ResponseGenerico<ResponseClienteCadastro>> IncluirCliente(ClienteCadastro parametros);

        Task<ResponseGenerico<string>> IncluirClientesPorLote(CadastrarClienteLote parametros);
    }
}
