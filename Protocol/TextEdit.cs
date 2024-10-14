using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class TextEdit
    {
        public TextEdit() { }

        /**
         * The range of the text document to be manipulated. To insert
         * text into a document create a range where start === end.
         */
        [JsonPropertyName("range")]
        public required Range Range { get; set; }

        /**
         * The string to be inserted. For delete operations use an
         * empty string.
         */
        [JsonPropertyName("newText")]
        public required string NewText { get; set; }
    }
}
