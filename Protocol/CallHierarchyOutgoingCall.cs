using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class CallHierarchyOutgoingCall
    {
        /**
		 * The item that is called.
		 */
        [JsonPropertyName("to")]
        public CallHierarchyItem To { get; set; }

        /**
		 * The range at which this item is called. This is the range relative to
		 * the caller, e.g the item passed to `callHierarchy/outgoingCalls` request.
		 */
        [JsonPropertyName("fromRanges")]
        public Range FromRanges { get; set; }
    }
}
