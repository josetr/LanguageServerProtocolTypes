using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class Color
    {
        /**
		 * The red component of this color in the range [0-1].
		 */
        [JsonPropertyName("red")]
        [JsonProperty(Required = Required.Always)]
        public float Red { get; set; }

        /**
		 * The green component of this color in the range [0-1].
		 */
        [JsonPropertyName("green")]
        [JsonProperty(Required = Required.Always)]
        public float Green { get; set; }

        /**
		 * The blue component of this color in the range [0-1].
		 */
        [JsonPropertyName("blue")]
        [JsonProperty(Required = Required.Always)]
        public float Blue { get; set; }

        /**
		 * The alpha component of this color in the range [0-1].
		 */
        [JsonPropertyName("alpha")]
        [JsonProperty(Required = Required.Always)]
        public float Alpha { get; set; }
    }
}
