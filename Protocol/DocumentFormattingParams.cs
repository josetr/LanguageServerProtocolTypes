using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentFormattingParams : WorkDoneProgressParams
    {
        public DocumentFormattingParams() { }

        /**
         * The document to format.
         */
        [JsonPropertyName("textDocument")]
        [JsonProperty(Required = Required.Always)]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
         * The format options.
         */
        [JsonPropertyName("options")]
        [JsonProperty(Required = Required.Always)]
        public FormattingOptions Options { get; set; }
    }
}
