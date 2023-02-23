using IntegracaoOmie.Models;
using IntegracaoOmie.Models.Cliente;
using IntegracaoOmie.Rest.Interface;
using IntegracaoOmie.Services.Interfaces;
using IntegracaoOmie.Validator.Cliente;
using System.Dynamic;

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

        public async Task<ResponseGenerico<ResponseClienteCadastro>> IncluirCliente(ClienteCadastro parametros)
        {
            var validator = new ClienteCadastroValidator();

            var resultado = validator.Validate(parametros);

            if(!resultado.IsValid)
            {
                var mensagensErro = resultado.Errors.Select(error => error.ErrorMessage).ToList();

                dynamic obj = new ExpandoObject();
                obj.mensagens = mensagensErro;
                return new ResponseGenerico<ResponseClienteCadastro> {
                    CodigoHttp = System.Net.HttpStatusCode.BadRequest,
                    ErroRetorno = obj
                };
            }

            var cliente = new RequestCadastrarCliente
            {
                call = "IncluirCliente",
                app_key = _requestBase.app_key,
                app_secret = _requestBase.app_secret,
            };

            cliente.Params.Add(parametros);

            return await _clienteRest.IncluirCliente(cliente);
        }

        public async Task<ResponseGenerico<string>> IncluirClientesPorLote(CadastrarClienteLote parametros)
        {
            var validator = new ClienteCadastroValidator();

            foreach(var parametro in parametros.ClientesCadastro)
            {
                var resultado = validator.Validate(parametro);

                if (!resultado.IsValid)
                {
                    var mensagensErro = resultado.Errors.Select(error => error.ErrorMessage).ToList();

                    dynamic obj = new ExpandoObject();
                    obj.mensagens = mensagensErro;
                    return new ResponseGenerico<string>
                    {
                        CodigoHttp = System.Net.HttpStatusCode.BadRequest,
                        ErroRetorno = obj
                    };
                }
            }

            var cliente = new RequestCadastrarClienteLote
            {
                call = "IncluirClientesPorLote",
                app_key = _requestBase.app_key,
                app_secret = _requestBase.app_secret,
            };

            cliente.Params.Add(parametros);

            return await _clienteRest.IncluirClientesPorLote(cliente);
        }

        public async Task<ResponseGenerico<List<ClienteCadastroCompleto>>> ListarClientes()
        {
            var listClientes = new RequestListar
            {
                call = "ListarClientes",
                app_key = _requestBase.app_key,
                app_secret = _requestBase.app_secret,
            };


            listClientes.Params.Add(new Param());

            return await _clienteRest.ListarClientes(listClientes);
        }

        public async Task<ResponseGenerico<List<ClienteCadastroResumido>>> ListarClientesResumido()
        {
            var listClientes = new RequestListar
            {
                call = "ListarClientesResumido",
                app_key = _requestBase.app_key,
                app_secret= _requestBase.app_secret,
            };
       

            listClientes.Params.Add(new Param());
            
            return await _clienteRest.ListarClientesResumido(listClientes);
          
        }
    }
}
