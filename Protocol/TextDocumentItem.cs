using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class TextDocumentItem
    {
        public TextDocumentItem() { }

        /**
         * The text document's URI.
         */
        [JsonPropertyName("uri")]
        [JsonProperty(Required = Required.Always)]
        public string Uri { get; set; }

        /**
         * The text document's language identifier.
         */
        [JsonPropertyName("languageId")]
        [JsonProperty(Required = Required.Always)]
        public string LanguageId { get; set; }

        /**
         * The version number of this document (it will increase after each
         * change, including undo/redo).
         */
        [JsonPropertyName("version")]
        [JsonProperty(Required = Required.Always)]
        public int Version { get; set; }

        /**
         * The content of the opened text document.
         */
        [JsonPropertyName("text")]
        [JsonProperty(Required = Required.Always)]
        public string Text { get; set; }
    }
}
