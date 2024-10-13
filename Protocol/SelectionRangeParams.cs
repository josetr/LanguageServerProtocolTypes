using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class SelectionRangeParams : WorkDoneProgressParams, IPartialResultParams
    {
        public SelectionRangeParams() : base() { }

        /**
		 * The text document.
		 */
        [JsonPropertyName("textDocument")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
		 * The positions inside the text document.
		 */
        [JsonPropertyName("positions")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Position[] Positions { get; set; }

        [JsonPropertyName("partialResultToken")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
