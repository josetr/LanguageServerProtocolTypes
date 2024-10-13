using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class FoldingRangeClientCapabilities
    {
        public FoldingRangeClientCapabilities() { }

        /**
         * Whether implementation supports dynamic registration for folding range
	     * providers. If this is set to `true` the client supports the new
	     * `FoldingRangeRegistrationOptions` return value for the corresponding
	     * server capability as well.
	     */
        [JsonPropertyName("dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }

        /**
         * The maximum number of folding ranges that the client prefers to receive
	     * per document. The value serves as a hint, servers are free to follow the
	     * limit.
         */
        [JsonPropertyName("rangeLimit")]
        public uint? RangeLimit { get; set; }

        /**
         * If set, the client signals that it only supports folding complete lines.
	     * If set, client will ignore specified `startCharacter` and `endCharacter`
	     * properties in a FoldingRange.
         */
        [JsonPropertyName("lineFoldingOnly")]
        public bool? LineFoldingOnly { get; set; }
    }
}