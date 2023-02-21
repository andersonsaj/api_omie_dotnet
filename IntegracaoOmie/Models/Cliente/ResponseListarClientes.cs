using Newtonsoft.Json;

namespace IntegracaoOmie.Models.Cliente
{
    public class ResponseListarClientes : Paginacao
    {
        [JsonProperty("clientes_cadastro")]
        public List<ClientesCadastro> ClientesCadastro;
    }
    public class ClientesCadastro
    {
        [JsonProperty("bairro")]
        public string Bairro;

        [JsonProperty("bloquear_faturamento")]
        public string BloquearFaturamento;

        [JsonProperty("cep")]
        public string Cep;

        [JsonProperty("cidade")]
        public string Cidade;

        [JsonProperty("cidade_ibge")]
        public string CidadeIbge;

        [JsonProperty("cnpj_cpf")]
        public string CnpjCpf;

        [JsonProperty("codigo_cliente_integracao")]
        public string CodigoClienteIntegracao;

        [JsonProperty("codigo_cliente_omie")]
        public int CodigoClienteOmie;

        [JsonProperty("codigo_pais")]
        public string CodigoPais;

        [JsonProperty("complemento")]
        public string Complemento;

        [JsonProperty("dadosBancarios")]
        public DadosBancarios DadosBancarios;

        [JsonProperty("email")]
        public string Email;

        [JsonProperty("endereco")]
        public string Endereco;

        [JsonProperty("enderecoEntrega")]
        public EnderecoEntrega EnderecoEntrega;

        [JsonProperty("endereco_numero")]
        public string EnderecoNumero;

        [JsonProperty("estado")]
        public string Estado;

        [JsonProperty("exterior")]
        public string Exterior;

        [JsonProperty("inativo")]
        public string Inativo;

        [JsonProperty("info")]
        public Info Info;

        [JsonProperty("inscricao_estadual")]
        public string InscricaoEstadual;

        [JsonProperty("inscricao_municipal")]
        public string InscricaoMunicipal;

        [JsonProperty("nome_fantasia")]
        public string NomeFantasia;

        [JsonProperty("optante_simples_nacional")]
        public string OptanteSimplesNacional;

        [JsonProperty("pessoa_fisica")]
        public string PessoaFisica;

        [JsonProperty("produtor_rural")]
        public string ProdutorRural;

        [JsonProperty("razao_social")]
        public string RazaoSocial;

        [JsonProperty("recomendacoes")]
        public Recomendacoes Recomendacoes;

        [JsonProperty("tags")]
        public List<Tag> Tags;

        [JsonProperty("telefone1_ddd")]
        public string Telefone1Ddd;

        [JsonProperty("telefone1_numero")]
        public string Telefone1Numero;

        [JsonProperty("telefone2_ddd")]
        public string Telefone2Ddd;

        [JsonProperty("telefone2_numero")]
        public string Telefone2Numero;

        [JsonProperty("valor_limite_credito")]
        public int ValorLimiteCredito;
    }

    public class DadosBancarios
    {
        [JsonProperty("agencia")]
        public string Agencia;

        [JsonProperty("codigo_banco")]
        public string CodigoBanco;

        [JsonProperty("conta_corrente")]
        public string ContaCorrente;

        [JsonProperty("doc_titular")]
        public string DocTitular;

        [JsonProperty("nome_titular")]
        public string NomeTitular;

        [JsonProperty("transf_padrao")]
        public string TransfPadrao;
    }

    public class EnderecoEntrega
    {
    }

    public class Info
    {
        [JsonProperty("cImpAPI")]
        public string CImpAPI;

        [JsonProperty("dAlt")]
        public string DAlt;

        [JsonProperty("dInc")]
        public string DInc;

        [JsonProperty("hAlt")]
        public string HAlt;

        [JsonProperty("hInc")]
        public string HInc;

        [JsonProperty("uAlt")]
        public string UAlt;

        [JsonProperty("uInc")]
        public string UInc;
    }

    public class Recomendacoes
    {
        [JsonProperty("codigo_transportadora")]
        public int CodigoTransportadora;

        [JsonProperty("gerar_boletos")]
        public string GerarBoletos;
    }
    public class Tag
    {
        [JsonProperty("tag")]
        public string tag;
    }


}
