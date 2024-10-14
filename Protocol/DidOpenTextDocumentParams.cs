using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DidOpenTextDocumentParams
    {
        public DidOpenTextDocumentParams() { }

        /**
         * The document that was opened.
         */
        [JsonPropertyName("textDocument")]
        public required TextDocumentItem TextDocument { get; set; }
    }
}
