using Newtonsoft.Json;

namespace IntegracaoOmie.Models;


public class RequestListar : RequestBase
{
    [JsonProperty("param")]
    public List<Param> Params { get; set; } = new List<Param>();
}

public class Param
{
    [JsonProperty]
    public int pagina { get; set; } = 1;
    [JsonProperty]
    public int registros_por_pagina { get; set; } = 100;
    [JsonProperty]
    public string apenas_importado_api { get; set; } = "N";
}
