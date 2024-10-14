using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DocumentFormattingParams : WorkDoneProgressParams
    {
        public DocumentFormattingParams() { }

        /**
         * The document to format.
         */
        [JsonPropertyName("textDocument")]
        public required TextDocumentIdentifier TextDocument { get; set; }

        /**
         * The format options.
         */
        [JsonPropertyName("options")]
        public required FormattingOptions Options { get; set; }
    }
}
