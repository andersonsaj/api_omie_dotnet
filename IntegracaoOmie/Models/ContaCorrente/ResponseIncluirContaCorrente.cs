using Newtonsoft.Json;

namespace IntegracaoOmie.Models.ContaCorrente;

public class ResponseIncluirContaCorrente
{
    [JsonProperty("nCodCC")]
    public long NCodCC { get; set; }

    [JsonProperty("cCodCCInt")]
    public string CCodCCInt { get; set; }

    [JsonProperty("cCodStatus")]
    public string CCodStatus { get; set; }

    [JsonProperty("cDesStatus")]
    public string CDesStatus { get; set; }
}
