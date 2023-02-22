
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace IntegracaoOmie.Models.Cliente;

public class RequestListarClientes : RequestBase
{
    [JsonProperty("param")]
    public List<Param> Params { get; set; } = new List<Param>();
}

