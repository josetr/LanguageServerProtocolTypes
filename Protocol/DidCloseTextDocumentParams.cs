using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DidCloseTextDocumentParams
    {
        public DidCloseTextDocumentParams() { }

        /**
         * The document that was closed.
         */
        [JsonPropertyName("textDocument")]
        public required TextDocumentIdentifier TextDocument { get; set; }
    }
}
