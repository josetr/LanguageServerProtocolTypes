using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class ConfigurationParams
    {
        public ConfigurationParams() { }

        [JsonPropertyName("items")]
        public required ConfigurationItem[] Items { get; set; }
    }
}
