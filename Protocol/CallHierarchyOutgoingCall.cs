using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CallHierarchyOutgoingCall
    {
        /**
		 * The item that is called.
		 */
        [DataMember(Name = "to")]
        public CallHierarchyItem To { get; set; }

        /**
		 * The range at which this item is called. This is the range relative to
		 * the caller, e.g the item passed to `callHierarchy/outgoingCalls` request.
		 */
        [DataMember(Name = "fromRanges")]
        public Range FromRanges { get; set; }
    }
}
