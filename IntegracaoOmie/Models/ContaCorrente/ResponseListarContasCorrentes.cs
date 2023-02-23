using Newtonsoft.Json;

namespace IntegracaoOmie.Models.ContaCorrente;

public class ResponseListarContasCorrentes : Paginacao
{
    [JsonProperty("ListarContasCorrentes")]
    public List<ListarContasCorrentes> ListarContasCorrentes { get; set; } = new List<ListarContasCorrentes>();
}

public class ListarContasCorrentes
{
    [JsonProperty("bloqueado")]
    public string Bloqueado { get; set; }

    [JsonProperty("bol_instr1")]
    public string BolInstr1 { get; set; }

    [JsonProperty("bol_sn")]
    public string BolSn { get; set; }

    [JsonProperty("cobr_sn")]
    public string CobrSn { get; set; }

    [JsonProperty("codigo_banco")]
    public string CodigoBanco { get; set; }

    [JsonProperty("data_alt")]
    public string DataAlt { get; set; }

    [JsonProperty("data_inc")]
    public string DataInc { get; set; }

    [JsonProperty("descricao")]
    public string Descricao { get; set; }

    [JsonProperty("hora_alt")]
    public string HoraAlt { get; set; }

    [JsonProperty("hora_inc")]
    public string HoraInc { get; set; }

    [JsonProperty("importado_api")]
    public string ImportadoApi { get; set; }

    [JsonProperty("inativo")]
    public string Inativo { get; set; }

    [JsonProperty("nCodCC")]
    public long NCodCC { get; set; }

    [JsonProperty("nao_fluxo")]
    public string NaoFluxo { get; set; }

    [JsonProperty("nao_resumo")]
    public string NaoResumo { get; set; }

    [JsonProperty("pdv_categoria")]
    public string PdvCategoria { get; set; }

    [JsonProperty("pdv_cod_adm")]
    public decimal PdvCodAdm { get; set; }

    [JsonProperty("pdv_enviar")]
    public string PdvEnviar { get; set; }

    [JsonProperty("pdv_sincr_analitica")]
    public string PdvSincrAnalitica { get; set; }

    [JsonProperty("pix_sn")]
    public string PixSn { get; set; }

    [JsonProperty("saldo_inicial")]
    public decimal SaldoInicial { get; set; }

    [JsonProperty("tipo")]
    public string Tipo { get; set; }

    [JsonProperty("tipo_conta_corrente")]
    public string TipoContaCorrente { get; set; }

    [JsonProperty("user_alt")]
    public string UserAlt { get; set; }
}
