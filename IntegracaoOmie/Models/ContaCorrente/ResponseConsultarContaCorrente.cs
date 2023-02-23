using Newtonsoft.Json;

namespace IntegracaoOmie.Models.ContaCorrente;

public class ResponseConsultarContaCorrente
{
    [JsonProperty("nCodCC")]
    public long NCodCC { get; set; }

    [JsonProperty("cCodCCInt")]
    public string CCodCCInt { get; set; }

    [JsonProperty("tipo_conta_corrente")]
    public string TipoContaCorrente { get; set; }

    [JsonProperty("codigo_banco")]
    public string CodigoBanco { get; set; }

    [JsonProperty("descricao")]
    public string Descricao { get; set; }

    [JsonProperty("codigo_agencia")]
    public string CodigoAgencia { get; set; }

    [JsonProperty("numero_conta_corrente")]
    public string NumeroContaCorrente { get; set; }

    [JsonProperty("saldo_inicial")]
    public decimal SaldoInicial { get; set; }

    [JsonProperty("saldo_data")]
    public string SaldoData { get; set; }

    [JsonProperty("valor_limite")]
    public decimal ValorLimite { get; set; }

    [JsonProperty("nao_fluxo")]
    public string NaoFluxo { get; set; }

    [JsonProperty("nao_resumo")]
    public string NaoResumo { get; set; }

    [JsonProperty("observacao")]
    public string Observacao { get; set; }

    [JsonProperty("cobr_sn")]
    public string CobrSn { get; set; }

    [JsonProperty("per_juros")]
    public decimal PerJuros { get; set; }

    [JsonProperty("per_multa")]
    public decimal PerMulta { get; set; }

    [JsonProperty("bol_instr1")]
    public string BolInstr1 { get; set; }

    [JsonProperty("bol_instr2")]
    public string BolInstr2 { get; set; }

    [JsonProperty("bol_instr3")]
    public string BolInstr3 { get; set; }

    [JsonProperty("bol_instr4")]
    public string BolInstr4 { get; set; }

    [JsonProperty("bol_sn")]
    public string BolSn { get; set; }

    [JsonProperty("pix_sn")]
    public string PixSn { get; set; }

    [JsonProperty("cnab_esp")]
    public string CnabEsp { get; set; }

    [JsonProperty("cobr_esp")]
    public string CobrEsp { get; set; }

    [JsonProperty("dias_rcomp")]
    public int DiasRcomp { get; set; }

    [JsonProperty("modalidade")]
    public string Modalidade { get; set; }

    [JsonProperty("cancinstr")]
    public string Cancinstr { get; set; }

    [JsonProperty("pdv_enviar")]
    public string PdvEnviar { get; set; }

    [JsonProperty("pdv_sincr_analitica")]
    public string PdvSincrAnalitica { get; set; }

    [JsonProperty("pdv_dias_venc")]
    public int PdvDiasVenc { get; set; }

    [JsonProperty("pdv_num_parcelas")]
    public int PdvNumParcelas { get; set; }

    [JsonProperty("pdv_tipo_tef")]
    public int PdvTipoTef { get; set; }

    [JsonProperty("pdv_cod_adm")]
    public int PdvCodAdm { get; set; }

    [JsonProperty("pdv_limite_pacelas")]
    public int PdvLimitePacelas { get; set; }

    [JsonProperty("pdv_taxa_loja")]
    public decimal PdvTaxaLoja { get; set; }

    [JsonProperty("pdv_taxa_adm")]
    public decimal PdvTaxaAdm { get; set; }

    [JsonProperty("pdv_categoria")]
    public string PdvCategoria { get; set; }

    [JsonProperty("cTipoCartao")]
    public string CTipoCartao { get; set; }

    [JsonProperty("cEstabelecimento")]
    public string CEstabelecimento { get; set; }

    [JsonProperty("nome_gerente")]
    public string NomeGerente { get; set; }

    [JsonProperty("ddd")]
    public string Ddd { get; set; }

    [JsonProperty("telefone")]
    public string Telefone { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("endereco")]
    public string Endereco { get; set; }

    [JsonProperty("numero")]
    public string Numero { get; set; }

    [JsonProperty("bairro")]
    public string Bairro { get; set; }

    [JsonProperty("complemento")]
    public string Complemento { get; set; }

    [JsonProperty("estado")]
    public string Estado { get; set; }

    [JsonProperty("cidade")]
    public string Cidade { get; set; }

    [JsonProperty("cep")]
    public string Cep { get; set; }

    [JsonProperty("codigo_pais")]
    public string CodigoPais { get; set; }

    [JsonProperty("data_inc")]
    public string DataInc { get; set; }

    [JsonProperty("hora_inc")]
    public string HoraInc { get; set; }

    [JsonProperty("user_inc")]
    public string UserInc { get; set; }

    [JsonProperty("data_alt")]
    public string DataAlt { get; set; }

    [JsonProperty("hora_alt")]
    public string HoraAlt { get; set; }

    [JsonProperty("user_alt")]
    public string UserAlt { get; set; }

    [JsonProperty("importado_api")]
    public string ImportadoApi { get; set; }

    [JsonProperty("bloqueado")]
    public string Bloqueado { get; set; }

    [JsonProperty("inativo")]
    public string Inativo { get; set; }
}
