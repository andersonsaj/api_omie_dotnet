using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace IntegracaoOmie.Models.Cliente;

public class ClienteCadastro
{
    [JsonProperty("codigo_cliente_integracao")]
    public string codigo_cliente_integracao { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("nome_fantasia")]
    public string nome_fantasia { get; set; }

    [JsonProperty("razao_social")]
    public string razao_social { get; set; }
}
