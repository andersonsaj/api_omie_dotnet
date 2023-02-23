using Newtonsoft.Json;

namespace IntegracaoOmie.Models.ContaCorrente;

public class RequestIncluirContaCorrente : RequestBase
{
    [JsonProperty("param")]
    public List<IncluirContaCorrente> Params { get; set; } = new List<IncluirContaCorrente>();
}

public class IncluirContaCorrente
{
    [JsonProperty("cCodCCInt")]
    public string CCodCCInt { get; set; }

    [JsonProperty("tipo_conta_corrente")]
    public string TipoContaCorrente { get; set; }

    [JsonProperty("codigo_banco")]
    public string CodigoBanco { get; set; }

    [JsonProperty("descricao")]
    public string Descricao { get; set; }

    [JsonProperty("saldo_inicial")]
    public decimal SaldoInicial { get; set; }
}
