using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace IntegracaoOmie.Models
{
    public class RequestBase
    {
        [JsonProperty]
        public string call { get; set; }
        [JsonProperty]
        public string app_key { get; set; }
        [JsonProperty]
        public string app_secret { get; set; }
    }
}
