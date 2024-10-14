using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class SelectionRange
    {
        public SelectionRange() { }

        /**
         * The [range](#Range) of this selection range.
         */
        [JsonPropertyName("range")]
        public required Range Range { get; set; }

        /**
         * The parent selection range containing this range. Therefore
	     * `parent.range` must contain `this.range`.
         */
        [JsonPropertyName("parent")]
        public SelectionRange Parent { get; set; }
    }
}
