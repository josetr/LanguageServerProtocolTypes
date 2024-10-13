using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class LinkedEditingRanges
    {
        public LinkedEditingRanges() { }

        /**
		  * A list of ranges that can be renamed together. The ranges must have
		  * identical length and contain identical text content. The ranges cannot overlap.
		  */
        [JsonPropertyName("ranges")]
        [JsonProperty(Required = Required.Always)]
        public Range Ranges { get; set; }

        /**
		 * An optional word pattern (regular expression) that describes valid contents for
		 * the given ranges. If no pattern is provided, the client configuration's word
		 * pattern will be used.
		 */
        [JsonPropertyName("wordPattern")]
        public string WordPattern { get; set; }
    }
}
