using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DocumentLinkParams : WorkDoneProgressParams, IPartialResultParams
    {
        public DocumentLinkParams() { }

        /**
         * The document to provide document links for.
         */
        [JsonPropertyName("textDocument")]
        public required TextDocumentIdentifier TextDocument { get; set; }

        /**
         * An optional token that a server can use to report partial results (e.g. streaming) to
         * the client.
         */
        [JsonPropertyName("partialResultToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
