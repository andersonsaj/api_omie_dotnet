using Newtonsoft.Json;

namespace IntegracaoOmie.Models;
public class Paginacao
{
    [JsonProperty("pagina")]
    public int Pagina { get; set; }

    [JsonProperty("total_de_paginas")]
    public int TotalDePaginas { get; set; }

    [JsonProperty("registros")]
    public int Registros { get; set; }

    [JsonProperty("total_de_registros")]
    public int TotalDeRegistros { get; set; }
}
