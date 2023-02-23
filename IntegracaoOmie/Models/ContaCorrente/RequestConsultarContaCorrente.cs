using Newtonsoft.Json;

namespace IntegracaoOmie.Models.ContaCorrente;

public class RequestConsultarContaCorrente : RequestBase
{
    [JsonProperty("param")]
    public List<ConsultarContaCorrente> Params { get; set; } = new List<ConsultarContaCorrente>();
}

public class ConsultarContaCorrente
{
    [JsonProperty("nCodCC")]
    public long NCodCC { get; set; }

    [JsonProperty("cCodCCInt")]
    public string NCodCCIntegracao { get; set; }
}
