using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    public class TextDocumentItem
    {
        public TextDocumentItem() { }

        /**
         * The text document's URI.
         */
        [JsonPropertyName("uri")]
        public required string Uri { get; set; }

        /**
         * The text document's language identifier.
         */
        [JsonPropertyName("languageId")]
        public required string LanguageId { get; set; }

        /**
         * The version number of this document (it will increase after each
         * change, including undo/redo).
         */
        [JsonPropertyName("version")]
        public required int Version { get; set; }

        /**
         * The content of the opened text document.
         */
        [JsonPropertyName("text")]
        public required string Text { get; set; }
    }
}
