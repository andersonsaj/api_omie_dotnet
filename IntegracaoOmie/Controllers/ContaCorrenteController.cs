using IntegracaoOmie.Models;
using IntegracaoOmie.Models.ContaCorrente;
using IntegracaoOmie.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegracaoOmie.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class ContaCorrenteController : ControllerBase
{
    [HttpPost("IncluirContaCorrente")]
    [ProducesResponseType(typeof(ResponseIncluirContaCorrente), StatusCodes.Status201Created)]
    public async Task<IActionResult> IncluirContaCorrente([FromServices] IContaCorrenteServices contaCorrenteServices, [FromBody] IncluirContaCorrente parametros)
    {
        var response = await contaCorrenteServices.IncluirContaCorrente(parametros);

        if (response.CodigoHttp == HttpStatusCode.OK)
        {
            return Created(string.Empty, response.DadosRetorno);
        }
        else
        {
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
    }

    [HttpGet("ListarContasCorrentes")]
    [ProducesResponseType(typeof(List<ListarContasCorrentes>), StatusCodes.Status200OK)]
    public async Task<IActionResult> ListarContasCorrentes([FromServices] IContaCorrenteServices contaCorrenteServices)
    {
        var response = await contaCorrenteServices.ListarContasCorrentes();

        if (response.CodigoHttp == HttpStatusCode.OK)
        {
            
            return Ok(response.DadosRetorno);
        }
        else
        {
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
    }

    [HttpPost("ConsultarContaCorrente")]
    [ProducesResponseType(typeof(ResponseConsultarContaCorrente), StatusCodes.Status200OK)]
    public async Task<IActionResult> ConsultarContaCorrente([FromServices] IContaCorrenteServices contaCorrenteServices, [FromBody] ConsultarContaCorrente parametros)
    {
        var response = await contaCorrenteServices.ConsultarContaCorrente(parametros);

        if (response.CodigoHttp == HttpStatusCode.OK)
        {

            return Ok(response.DadosRetorno);
        }
        else
        {
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
    }
}
