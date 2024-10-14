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
        public required TextDocumentIdentifier TextDocument { get; set; }

        /**
         * The range to format
         */
        [JsonPropertyName("range")]
        public required Range Range { get; set; }

        /**
         * The format options
         */
        [JsonPropertyName("options")]
        public required FormattingOptions Options { get; set; }
    }
}
