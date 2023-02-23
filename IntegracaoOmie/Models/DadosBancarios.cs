using Newtonsoft.Json;

namespace IntegracaoOmie.Models;

public class DadosBancarios
{
    [JsonProperty("agencia")]
    public string Agencia { get; set; }

    [JsonProperty("codigo_banco")]
    public string CodigoBanco { get; set; }

    [JsonProperty("conta_corrente")]
    public string ContaCorrente { get; set; }

    [JsonProperty("doc_titular")]
    public string DocTitular { get; set; }

    [JsonProperty("nome_titular")]
    public string NomeTitular { get; set; }

    [JsonProperty("transf_padrao")]
    public string TransfPadrao { get; set; }
}
