using Newtonsoft.Json;

namespace IntegracaoOmie.Models.Cliente
{
    public class ResponseListarClientes : Paginacao
    {
        [JsonProperty("clientes_cadastro")]
        public List<ClienteCadastroCompleto> ClientesCadastro { get; set; }
    }
    public class ClienteCadastroCompleto
    {
        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("bloquear_faturamento")]
        public string BloquearFaturamento { get; set; }

        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("cidade")]
        public string Cidade { get; set; }

        [JsonProperty("cidade_ibge")]
        public string CidadeIbge { get; set; }

        [JsonProperty("cnpj_cpf")]
        public string CnpjCpf { get; set; }

        [JsonProperty("codigo_cliente_integracao")]
        public string CodigoClienteIntegracao { get; set; }

        [JsonProperty("codigo_cliente_omie")]
        public int CodigoClienteOmie { get; set; }

        [JsonProperty("codigo_pais")]
        public string CodigoPais { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("dadosBancarios")]
        public DadosBancarios DadosBancarios { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("endereco")]
        public string Endereco { get; set; }

        [JsonProperty("enderecoEntrega")]
        public EnderecoEntrega EnderecoEntrega { get; set; }

        [JsonProperty("endereco_numero")]
        public string EnderecoNumero { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; }

        [JsonProperty("exterior")]
        public string Exterior { get; set; }

        [JsonProperty("inativo")]
        public string Inativo { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("inscricao_estadual")]
        public string InscricaoEstadual { get; set; }

        [JsonProperty("inscricao_municipal")]
        public string InscricaoMunicipal { get; set; }

        [JsonProperty("nome_fantasia")]
        public string NomeFantasia { get; set; }

        [JsonProperty("optante_simples_nacional")]
        public string OptanteSimplesNacional { get; set; }

        [JsonProperty("pessoa_fisica")]
        public string PessoaFisica { get; set; }

        [JsonProperty("produtor_rural")]
        public string ProdutorRural { get; set; }

        [JsonProperty("razao_social")]
        public string RazaoSocial { get; set; }

        [JsonProperty("recomendacoes")]
        public Recomendacoes Recomendacoes { get; set; }

        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }

        [JsonProperty("telefone1_ddd")]
        public string Telefone1Ddd { get; set; }

        [JsonProperty("telefone1_numero")]
        public string Telefone1Numero { get; set; }

        [JsonProperty("telefone2_ddd")]
        public string Telefone2Ddd { get; set; }

        [JsonProperty("telefone2_numero")]
        public string Telefone2Numero { get; set; }

        [JsonProperty("valor_limite_credito")]
        public int ValorLimiteCredito { get; set; }
    }

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

    public class EnderecoEntrega
    {
    }

    public class Info
    {
        [JsonProperty("cImpAPI")]
        public string CImpAPI { get; set; }

        [JsonProperty("dAlt")]
        public string DAlt { get; set; }

        [JsonProperty("dInc")]
        public string DInc { get; set; }

        [JsonProperty("hAlt")]
        public string HAlt { get; set; }

        [JsonProperty("hInc")]
        public string HInc { get; set; }

        [JsonProperty("uAlt")]
        public string UAlt { get; set; }

        [JsonProperty("uInc")]
        public string UInc { get; set; }
    }

    public class Recomendacoes
    {
        [JsonProperty("codigo_transportadora")]
        public int CodigoTransportadora { get; set; }

        [JsonProperty("gerar_boletos")]
        public string GerarBoletos { get; set; }
    }
    public class Tag
    {
        [JsonProperty("tag")]
        public string tag { get; set; }
    }


}
