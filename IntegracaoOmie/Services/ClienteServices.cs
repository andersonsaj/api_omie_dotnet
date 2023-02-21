using IntegracaoOmie.Models;
using IntegracaoOmie.Models.Cliente;
using IntegracaoOmie.Rest.Interface;
using IntegracaoOmie.Services.Interfaces;

namespace IntegracaoOmie.Services
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRest _clienteRest;
        private readonly RequestBase _requestBase;

        public ClienteServices(IClienteRest clienteRest, RequestBase requestBase)
        {
            _clienteRest = clienteRest;
            _requestBase = requestBase;
        }

        public async Task<ResponseGenerico<List<ClientesCadastro>>> ListarClientes()
        {
            var listClientes = new RequestListarClientes
            {
                call = "ListarClientes",
                app_key = _requestBase.app_key,
                app_secret = _requestBase.app_secret,
            };


            listClientes.param.Add(new Param());

            return await _clienteRest.ListarClientes(listClientes);
        }

        public async Task<ResponseGenerico<List<ClientesCadastroResumido>>> ListarClientesResumido()
        {
            var listClientes = new RequestListarClientes
            {
                call = "ListarClientesResumido",
                app_key = _requestBase.app_key,
                app_secret= _requestBase.app_secret,
            };
       

            listClientes.param.Add(new Param());
            
            return await _clienteRest.ListarClientesResumido(listClientes);
          
        }
    }
}
