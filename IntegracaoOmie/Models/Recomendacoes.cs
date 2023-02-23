using Newtonsoft.Json;

namespace IntegracaoOmie.Models;

public class Recomendacoes
{
    [JsonProperty("numero_parcelas")]
    public string NumeroParcelas { get; set; }

    [JsonProperty("codigo_vendedor")]
    public int CodigoVendedor { get; set; }

    [JsonProperty("email_fatura")]
    public string EmailFatura { get; set; }

    [JsonProperty("codigo_transportadora")]
    public int CodigoTransportadora { get; set; }

    [JsonProperty("gerar_boletos")]
    public string GerarBoletos { get; set; }

    [JsonProperty("tipo_assinante")]
    public string TipoAssinante { get; set; }
}
