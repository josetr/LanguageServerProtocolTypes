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
        public required float Red { get; set; }

        /**
		 * The green component of this color in the range [0-1].
		 */
        [JsonPropertyName("green")]
        public required float Green { get; set; }

        /**
		 * The blue component of this color in the range [0-1].
		 */
        [JsonPropertyName("blue")]
        public required float Blue { get; set; }

        /**
		 * The alpha component of this color in the range [0-1].
		 */
        [JsonPropertyName("alpha")]
        public required float Alpha { get; set; }
    }
}
