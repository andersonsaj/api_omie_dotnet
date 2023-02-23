using IntegracaoOmie.Models;
using IntegracaoOmie.Models.ContaCorrente;

namespace IntegracaoOmie.Rest.Interfaces;

public interface IContaCorrenteRest
{
    Task<ResponseGenerico<ResponseIncluirContaCorrente>> IncluirContaCorrente(RequestIncluirContaCorrente parametros);

    Task<ResponseGenerico<List<ListarContasCorrentes>>> ListarContasCorrentes(RequestListar parametros);

    Task<ResponseGenerico<ResponseConsultarContaCorrente>> ConsultarContaCorrente(RequestConsultarContaCorrente parametros);
}
