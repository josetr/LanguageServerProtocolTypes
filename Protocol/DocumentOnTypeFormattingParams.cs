using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DocumentOnTypeFormattingParams : TextDocumentPositionParams
    {
        public DocumentOnTypeFormattingParams() { }

        /**
         * The character that has been typed.
         */
        [JsonPropertyName("ch")]
        public required string Character { get; set; }

        /**
         * The format options.
         */
        [JsonPropertyName("options")]
        public required FormattingOptions Options { get; set; }
    }
}
