using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    public class TextDocumentIdentifier
    {
        public TextDocumentIdentifier() { }

        /**
         * The text document's URI.
         */
        [JsonPropertyName("uri")]
        public required string Uri { get; set; }
    }
}
