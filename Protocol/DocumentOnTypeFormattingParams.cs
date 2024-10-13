using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DocumentOnTypeFormattingParams : TextDocumentPositionParams
    {
        public DocumentOnTypeFormattingParams() { }

        /**
         * The character that has been typed.
         */
        [JsonPropertyName("ch")]
        [JsonProperty(Required = Required.Always)]
        public string Character { get; set; }

        /**
         * The format options.
         */
        [JsonPropertyName("options")]
        [JsonProperty(Required = Required.Always)]
        public FormattingOptions Options { get; set; }
    }
}
