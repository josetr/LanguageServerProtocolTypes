using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class TextDocumentPositionParams
    {
        public TextDocumentPositionParams() { }

        /**
         * The text document.
         */
        [JsonPropertyName("textDocument")]
        public required TextDocumentIdentifier TextDocument { get; set; }

        /**
         * The position inside the text document.
         */
        [JsonPropertyName("position")]
        public required Position Position { get; set; }
    }
}
