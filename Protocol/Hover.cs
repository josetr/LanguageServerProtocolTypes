using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * The result of a hover request.
     */
    public class Hover
    {
        public Hover() { }

        /**
         * The hover's content
         */
        [JsonPropertyName("contents")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public required SumType<string, MarkedString, MarkedString[], MarkupContent> Contents { get; set; }

        /**
         * An optional range is a range inside a text document
         * that is used to visualize a hover, e.g. by changing the background color.
         */
        [JsonPropertyName("range")]
        public Range Range { get; set; }
    }
}
