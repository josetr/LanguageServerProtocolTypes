using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DidSaveTextDocumentParams
    {
        public DidSaveTextDocumentParams() { }

        /**
         * The document that was saved.
         */
        [JsonPropertyName("textDocument")]
        public required TextDocumentIdentifier TextDocument { get; set; }

        /**
         * Optional the content when saved. Depends on the includeText value
         * when the save notification was requested.
         */
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
