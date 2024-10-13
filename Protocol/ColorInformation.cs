using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class ColorInformation
    {
        public ColorInformation() { }

        /**
		 * The range in the document where this color appears.
		 */
        [JsonPropertyName("range")]
        [JsonProperty(Required = Required.Always)]
        public Range Range { get; set; }

        /**
		 * The actual color value for this color range.
		 */
        [JsonPropertyName("color")]
        [JsonProperty(Required = Required.Always)]
        public Color Color { get; set; }
    }
}
