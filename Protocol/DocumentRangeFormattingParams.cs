using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DocumentRangeFormattingParams : WorkDoneProgressParams
    {
        public DocumentRangeFormattingParams() { }

        /**
         * The document to format.
         */
        [JsonPropertyName("textDocument")]
        [JsonProperty(Required = Required.Always)]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
         * The range to format
         */
        [JsonPropertyName("range")]
        [JsonProperty(Required = Required.Always)]
        public Range Range { get; set; }

        /**
         * The format options
         */
        [JsonPropertyName("options")]
        [JsonProperty(Required = Required.Always)]
        public FormattingOptions Options { get; set; }
    }
}
