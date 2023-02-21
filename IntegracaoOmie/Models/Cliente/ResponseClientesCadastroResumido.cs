using Newtonsoft.Json;

namespace IntegracaoOmie.Models.Cliente;

//[JsonObject("clientes_cadastro_resumido")]
public class ResponseClientesCadastroResumido : Paginacao
{
    [JsonProperty("clientes_cadastro_resumido")]
    public IEnumerable<ClientesCadastroResumido> clientes { get; set; } = new List<ClientesCadastroResumido>();
}

public class ClientesCadastroResumido
{
    [JsonProperty("cnpj_cpf")]
    public string CnpjCpf;

    [JsonProperty("codigo_cliente")]
    public long CodigoCliente;

    [JsonProperty("codigo_cliente_integracao")]
    public string CodigoClienteIntegracao;

    [JsonProperty("nome_fantasia")]
    public string NomeFantasia;

    [JsonProperty("razao_social")]
    public string RazaoSocial;
}