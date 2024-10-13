using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CallHierarchyIncomingCall
    {
        /**
		 * The item that makes the call.
		 */
        [JsonPropertyName("from")]
        public CallHierarchyItem From { get; set; }

        /**
		 * The ranges at which the calls appear. This is relative to the caller
		 * denoted by [`this.from`](#CallHierarchyIncomingCall.from).
		 */
        [JsonPropertyName("fromRanges")]
        public Range[] FromRanges { get; set; }
    }
}
