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
        public required Range Range { get; set; }

        /**
		 * The actual color value for this color range.
		 */
        [JsonPropertyName("color")]
        public required Color Color { get; set; }
    }
}
