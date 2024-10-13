using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class TextDocumentPositionParams
    {
        public TextDocumentPositionParams() { }

        /**
         * The text document.
         */
        [JsonPropertyName("textDocument")]
        [JsonProperty(Required = Required.Always)]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
         * The position inside the text document.
         */
        [JsonPropertyName("position")]
        [JsonProperty(Required = Required.Always)]
        public Position Position { get; set; }
    }
}
