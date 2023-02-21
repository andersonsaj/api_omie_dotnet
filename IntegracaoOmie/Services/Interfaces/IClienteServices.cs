using IntegracaoOmie.Models.Cliente;
using IntegracaoOmie.Models;

namespace IntegracaoOmie.Services.Interfaces
{
    public interface IClienteServices
    {
        public Task<ResponseGenerico<List<ClientesCadastroResumido>>> ListarClientesResumido();
        public Task<ResponseGenerico<List<ClientesCadastro>>> ListarClientes();
    }
}
