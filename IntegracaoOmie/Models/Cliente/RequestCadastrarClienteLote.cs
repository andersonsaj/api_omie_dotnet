using Newtonsoft.Json;

namespace IntegracaoOmie.Models.Cliente
{
    public class RequestCadastrarClienteLote : RequestBase
    {
        [JsonProperty("param")]
        public List<CadastrarClienteLote> Params { get; set; } = new List<CadastrarClienteLote>();
    }

    public class CadastrarClienteLote
    {
        [JsonProperty("clientes_cadastro")]
        public List<ClienteCadastro> ClientesCadastro { get; set; }

        [JsonProperty("lote")]
        public int Lote { get; set; } = 1;
    }

}
