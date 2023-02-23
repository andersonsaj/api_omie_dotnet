using Newtonsoft.Json;

namespace IntegracaoOmie.Models;

public class Info
{
    [JsonProperty("cImpAPI")]
    public string CImpAPI { get; set; }

    [JsonProperty("dAlt")]
    public string DAlt { get; set; }

    [JsonProperty("dInc")]
    public string DInc { get; set; }

    [JsonProperty("hAlt")]
    public string HAlt { get; set; }

    [JsonProperty("hInc")]
    public string HInc { get; set; }

    [JsonProperty("uAlt")]
    public string UAlt { get; set; }

    [JsonProperty("uInc")]
    public string UInc { get; set; }
}
