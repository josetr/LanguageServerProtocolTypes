using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class RegularExpressionsClientCapabilities
    {
        public RegularExpressionsClientCapabilities() { }

        /**
		 * The engine's name.
		 */
        [JsonPropertyName("engine")]
        [JsonProperty(Required = Required.Always)]
        public string Engine { get; set; }

        /**
		 * The engine's version.
		 */
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
