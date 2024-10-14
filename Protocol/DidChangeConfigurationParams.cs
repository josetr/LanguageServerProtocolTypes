using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DidChangeConfigurationParams
    {
        public DidChangeConfigurationParams() { }

        /**
         * The actual changed settings
         */
        [JsonPropertyName("settings")]
        public required object Settings { get; set; }
    }
}
