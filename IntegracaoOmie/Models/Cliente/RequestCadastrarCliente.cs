using Newtonsoft.Json;

namespace IntegracaoOmie.Models.Cliente;

public class RequestCadastrarCliente : RequestBase
{
    [JsonProperty("param")]
    public List<ClienteCadastro> Params { get; set; } = new List<ClienteCadastro>();
}
