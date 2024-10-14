using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class Moniker
    {
        public Moniker() { }

        /**
		 * The scheme of the moniker. For example tsc or .Net
		 */
        [JsonPropertyName("scheme")]
        public required string Scheme { get; set; }

        /**
		 * The identifier of the moniker. The value is opaque in LSIF however
		 * schema owners are allowed to define the structure if they want.
		 */
        [JsonPropertyName("identifier")]
        public required string Identifier { get; set; }

        /**
		 * The scope in which the moniker is unique
		 */
        [JsonPropertyName("unique")]
        public required UniquenessLevel Unique { get; set; }

        /**
		 * The moniker kind if known.
		 */
        [JsonPropertyName("kine")]
        public MonikerKind? Kind { get; set; }
    }
}
