using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class ConfigurationParams
    {
        public ConfigurationParams() { }

        [JsonPropertyName("items")]
        [JsonProperty(Required = Required.Always)]
        public ConfigurationItem[] Items { get; set; }
    }
}
