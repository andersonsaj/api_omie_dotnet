using Newtonsoft.Json;

namespace IntegracaoOmie.Models;

public class Tag
{
    [JsonProperty("tag")]
    public string tag { get; set; }
}
