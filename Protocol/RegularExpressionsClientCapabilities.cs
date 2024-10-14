using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class RegularExpressionsClientCapabilities
    {
        public RegularExpressionsClientCapabilities() { }

        /**
		 * The engine's name.
		 */
        [JsonPropertyName("engine")]
        public required string Engine { get; set; }

        /**
		 * The engine's version.
		 */
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
