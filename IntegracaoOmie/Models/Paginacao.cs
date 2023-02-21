using Newtonsoft.Json;

namespace IntegracaoOmie.Models;
public class Paginacao
{
    [JsonProperty("pagina")]
    public int Pagina;

    [JsonProperty("total_de_paginas")]
    public int TotalDePaginas;

    [JsonProperty("registros")]
    public int Registros;

    [JsonProperty("total_de_registros")]
    public int TotalDeRegistros;
}
