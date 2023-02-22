using Newtonsoft.Json;

namespace IntegracaoOmie.Models.Cliente
{
    public class ResponseClienteCadastro
    {
        [JsonProperty("codigo_cliente_omie")]
        public long CodigoClienteOmie { get; set; }

        [JsonProperty("codigo_cliente_integracao")]
        public string CodigoClienteIntegracao { get; set; }

        [JsonProperty("codigo_status")]
        public string CodigoStatus {  get; set; }

        [JsonProperty("descricao_status")]
        public string DescricaoStatus { get; set; } 
    }
}
