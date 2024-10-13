using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DidSaveTextDocumentParams
    {
        public DidSaveTextDocumentParams() { }

        /**
         * The document that was saved.
         */
        [DataMember(Name = "textDocument")]
        [JsonProperty(Required = Required.Always)]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
         * Optional the content when saved. Depends on the includeText value
         * when the save notification was requested.
         */
        [DataMember(Name = "text")]
        public string Text { get; set; }
    }
}
