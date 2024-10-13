using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class TextEdit
    {
        public TextEdit() { }

        /**
         * The range of the text document to be manipulated. To insert
         * text into a document create a range where start === end.
         */
        [JsonPropertyName("range")]
        [JsonProperty(Required = Required.Always)]
        public Range Range { get; set; }

        /**
         * The string to be inserted. For delete operations use an
         * empty string.
         */
        [JsonPropertyName("newText")]
        [JsonProperty(Required = Required.Always)]
        public string NewText { get; set; }
    }
}
