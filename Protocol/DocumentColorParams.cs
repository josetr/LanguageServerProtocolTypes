using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    public class DocumentColorParams : WorkDoneProgressParams, IPartialResultParams
    {
        public DocumentColorParams() : base() { }

        /**
	     * The text document.
	     */
        [JsonPropertyName("textDocument")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public TextDocumentIdentifier TextDocument { get; set; }

        [JsonPropertyName("partialResultToken")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<int, string> PartialResultToken { get; set; }

    }
}
