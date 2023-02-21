
using System.Text.Json.Serialization;

namespace IntegracaoOmie.Models.Cliente;

public class RequestListarClientes : RequestBase
{
    public List<Param> param { get; set; } = new List<Param>();
}

