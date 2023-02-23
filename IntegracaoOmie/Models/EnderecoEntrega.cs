using Newtonsoft.Json;

namespace IntegracaoOmie.Models;

public class EnderecoEntrega
{
    [JsonProperty("entRazaoSocial")]
    public string EntRazaoSocial { get; set; }

    [JsonProperty("entCnpjCpf")]
    public string EntCnpjCpf { get; set; }

    [JsonProperty("entEndereco")]
    public string EntEndereco { get; set; }

    [JsonProperty("entNumero")]
    public string EntNumero { get; set; }

    [JsonProperty("entComplemento")]
    public string EntComplemento { get; set; }

    [JsonProperty("entBairro")]
    public string EntBairro { get; set; }

    [JsonProperty("entCEP")]
    public string EntCEP { get; set; }

    [JsonProperty("entEstado")]
    public string EntEstado { get; set; }

    [JsonProperty("entCidade")]
    public string EntCidade { get; set; }

    [JsonProperty("entSepararEndereco")]
    public string EntSepararEndereco { get; set; }

    [JsonProperty("entTelefone")]
    public string EntTelefone { get; set; }

    [JsonProperty("entIE")]
    public string EntIE { get; set; }

}
