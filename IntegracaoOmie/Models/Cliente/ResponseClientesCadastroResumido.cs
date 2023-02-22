using Newtonsoft.Json;

namespace IntegracaoOmie.Models.Cliente;

//[JsonObject("clientes_cadastro_resumido")]
public class ResponseClientesCadastroResumido : Paginacao
{
    [JsonProperty("clientes_cadastro_resumido")]
    public IEnumerable<ClienteCadastroResumido> clientes { get; set; } = new List<ClienteCadastroResumido>();
}

public class ClienteCadastroResumido
{
    [JsonProperty("cnpj_cpf")]
    public string CnpjCpf { get; set; }

    [JsonProperty("codigo_cliente")]
    public long CodigoCliente { get; set; }

    [JsonProperty("codigo_cliente_integracao")]
    public string CodigoClienteIntegracao { get; set; }

    [JsonProperty("nome_fantasia")]
    public string NomeFantasia { get; set; }

    [JsonProperty("razao_social")]
    public string RazaoSocial { get; set; }
}