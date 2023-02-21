using Newtonsoft.Json;

namespace IntegracaoOmie.Models;

[JsonObject(MemberSerialization.OptIn)]
public class Param
{
    [JsonProperty]
    public int pagina { get; set; } = 1;
    [JsonProperty]
    public int registros_por_pagina { get; set; } = 100;
    [JsonProperty]
    public string apenas_importado_api { get; set; } = "N";
}
