using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokensRangeParams : WorkDoneProgressParams, IPartialResultParams
    {
        public SemanticTokensRangeParams() : base() { }

        /**
	     * The text document.
	     */
        [JsonPropertyName("textDocument")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
         * The range the semantic tokens are requested for.
         */
        [JsonPropertyName("range")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Range Range { get; set; }

        [JsonPropertyName("partialResultToken")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
