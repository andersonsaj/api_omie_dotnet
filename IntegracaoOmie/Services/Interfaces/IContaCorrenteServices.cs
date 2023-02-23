using IntegracaoOmie.Models.ContaCorrente;
using IntegracaoOmie.Models;

namespace IntegracaoOmie.Services.Interfaces;

public interface IContaCorrenteServices
{
    Task<ResponseGenerico<ResponseIncluirContaCorrente>> IncluirContaCorrente(IncluirContaCorrente parametros);

    Task<ResponseGenerico<List<ListarContasCorrentes>>> ListarContasCorrentes();

    Task<ResponseGenerico<ResponseConsultarContaCorrente>> ConsultarContaCorrente(ConsultarContaCorrente parametros);
}
