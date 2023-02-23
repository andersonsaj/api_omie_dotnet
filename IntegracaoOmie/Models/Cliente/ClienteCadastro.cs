using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace IntegracaoOmie.Models.Cliente;

public class ClienteCadastro
{
    [JsonProperty("codigo_cliente_integracao")]
    public string codigo_cliente_integracao { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("nome_fantasia")]
    public string nome_fantasia { get; set; }

    [JsonProperty("razao_social")]
    public string razao_social { get; set; }

    [JsonProperty("cnpj_cpf")]
    public string CnpjCpf { get; set; }

    [JsonProperty("telefone1_ddd")]
    public string Telefone1DDD { get; set; }

    [JsonProperty("telefone1_numero")]
    public string telefone1Numero { get; set; }

    [JsonProperty("contato")]
    public string Contato { get; set; }

    [JsonProperty("endereco")]
    public string Endereco { get; set; }

    [JsonProperty("endereco_numero")]
    public string EnderecoNumero { get; set; }

    [JsonProperty("bairro")]
    public string Bairro { get; set; }

    [JsonProperty("complemento")]
    public string Complemento { get; set; }

    [JsonProperty("estado")]
    public string Estado { get; set; }

    [JsonProperty("Cidade")]
    public string Cidade { get; set; }

    [JsonProperty("cep")]
    public string Cep { get; set; }

    [JsonProperty("codigo_pais")]
    public string CodigoPais { get; set; }

    [JsonProperty("separar_endereco")]
    public string SepararEndereco { get; set; } //N ou S

    [JsonProperty("pesquisar_cep")]
    public string PesquisarCep { get; set; } //N ou S

    [JsonProperty("telefone2_ddd")]
    public string Telefone2DDD { get; set; }

    [JsonProperty("telefone2_numero")]
    public string Telefone2Numero { get; set; }

    [JsonProperty("fax_ddd")]
    public string FaxDDD { get; set; }

    [JsonProperty("fax_numero")]
    public string FaxNumero { get; set; }

    [JsonProperty("homepage")]
    public string HomePage { get; set; }

    [JsonProperty("inscricao_estadual")]
    public string InscricaoEstadual { get; set; }

    [JsonProperty("inscricao_municipal")]
    public string InscricaoMunicipal { get; set; }

    [JsonProperty("inscricao_suframa")]
    public string InscricaoSuframa { get; set; }

    [JsonProperty("optante_simples_nacional")]
    public string OptanteSimplesNacional { get; set; } //S ou N

    [JsonProperty("produtor_rural")]
    public string ProdutorRural { get; set; } //S ou N

    [JsonProperty("contribuinte")]
    public string Contribuinte { get; set; } //S ou N

    [JsonProperty("observacao")]
    public string Observacao { get; set; }

    [JsonProperty("obs_detalhadas")]
    public string ObsDetalhadas { get; set; }

    [JsonProperty("recomendacao_atraso")]
    public string RecomendacaoAtraso { get; set; }

    [JsonProperty("tags")]
    public List<Tag> Tags { get; set; }

    [JsonProperty("pessoa_fisica")]
    public string PessoaFisica { get; set; } //S ou N

    [JsonProperty("exterior")]
    public string Exterior { get; set; } //S ou N

    [JsonProperty("logradouro")]
    public string Logradouro { get; set; }

    [JsonProperty("importado_api")]
    public string ImportadoApi { get; set; } //S ou N

    [JsonProperty("bloqueado")]
    public string Bloqueado { get; set; } //S ou N

    [JsonProperty("cidade_ibge")]
    public string CidadeIbge { get; set; }

    [JsonProperty("valor_limite_credito")]
    public string ValorLimiteCredito { get; set; }

    [JsonProperty("bloquear_faturamento")]
    public string BloquearFaturamento { get; set; } //S ou N

    [JsonProperty("recomendacoes")]
    public Recomendacoes Recomendacoes { get; set; }

    [JsonProperty("nif")]
    public string NIF { get; set; }

    [JsonProperty("documento_exterior")]
    public string DocumentoExterior { get; set; }

    [JsonProperty("inativo")]
    public string Inativo { get; set; }

    [JsonProperty("dadosBancarios")]
    public DadosBancarios DadosBancarios { get; set; }

    [JsonProperty("enviar_anexos")]
    public string EnviarAnexos { get; set; } //S ou N

    [JsonProperty("info")]
    public Info Info { get; set; }

    [JsonProperty("bloquear_exclusao")]
    public string BloquearExclusao { get; set; } //S ou N
}
