using IntegracaoOmie.Models.Cliente;
using IntegracaoOmie.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace IntegracaoOmie.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private readonly IClienteServices _clienteServices;

    public ClientesController(IClienteServices clienteServices)
    {
        _clienteServices = clienteServices;
    }

    [HttpGet("ListarClientes")]
    [ProducesResponseType(typeof(List<ClientesCadastro>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> ListarClientes()
    {
        var response = await _clienteServices.ListarClientes();
        if (response.CodigoHttp == HttpStatusCode.OK)
        {
            var clientes = response.DadosRetorno;
            return Ok(JsonConvert.SerializeObject(clientes));
        }
        else
        {
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
    }

    [HttpGet("ListarClientesResumido")]
    [ProducesResponseType(typeof(List<ClientesCadastroResumido>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> ListarClientesResumido()
    {
        var response = await _clienteServices.ListarClientesResumido();
        if (response.CodigoHttp == HttpStatusCode.OK)
        {
            var clientes = response.DadosRetorno;
            return Ok(JsonConvert.SerializeObject(clientes));
        }
        else
        {
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
    }
}
