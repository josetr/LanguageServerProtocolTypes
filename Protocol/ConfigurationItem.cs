using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class ConfigurationItem
    {
        public ConfigurationItem() { }

        /**
         * The scope to get the configuration section for.
         */
        [JsonPropertyName("scopeUri")]
        public string ScopeUri { get; set; }

        /**
         * The configuration section asked for.
         */
        [JsonPropertyName("section")]
        public string Section { get; set; }
    }
}