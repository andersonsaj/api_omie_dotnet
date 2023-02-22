using IntegracaoOmie.Models.Cliente;
using IntegracaoOmie.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace IntegracaoOmie.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class ClienteController : ControllerBase
{

    [HttpPost("IncluirCliente")]
    [ProducesResponseType(typeof(ResponseClienteCadastro), StatusCodes.Status201Created)]
    public async Task<IActionResult> IncluirCliente([FromServices] IClienteServices clienteServices, [FromBody] ClienteCadastro parametros)
    {
       var response = await clienteServices.IncluirCliente(parametros);

        if (response.CodigoHttp == HttpStatusCode.OK)
        {
            var cliente = response.DadosRetorno;
            return Created(string.Empty, cliente);
        }
        else
        {
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
    }

    [HttpPost("IncluirClientesPorLote")]
    [ProducesResponseType(typeof(ResponseClienteCadastro), StatusCodes.Status201Created)]
    public async Task<IActionResult> IncluirClientesPorLote([FromServices] IClienteServices clienteServices, [FromBody] CadastrarClienteLote parametros)
    {
        var response = await clienteServices.IncluirClientesPorLote(parametros);

        if (response.CodigoHttp == HttpStatusCode.OK)
        {
            var cliente = response.DadosRetorno;
            return Created(string.Empty, cliente);
        }
        else
        {
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
    }

    [HttpGet("ListarClientes")]
    [ProducesResponseType(typeof(List<ClienteCadastroCompleto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> ListarClientes([FromServices] IClienteServices clienteServices)
    {
        var response = await clienteServices.ListarClientes();
        if (response.CodigoHttp == HttpStatusCode.OK)
        {
            var clientes = response.DadosRetorno;
            return Ok(clientes);
        }
        else
        {
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
    }

    [HttpGet("ListarClientesResumido")]
    [ProducesResponseType(typeof(List<ClienteCadastroResumido>), StatusCodes.Status200OK)]
    public async Task<IActionResult> ListarClientesResumido([FromServices] IClienteServices clienteServices)
    {
        var response = await clienteServices.ListarClientesResumido();
        if (response.CodigoHttp == HttpStatusCode.OK)
        {
            var clientes = response.DadosRetorno;
            return Ok(clientes);
        }
        else
        {
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
    }
}
