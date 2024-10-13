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
        [DataMember(Name = "from")]
        public CallHierarchyItem From { get; set; }

        /**
		 * The ranges at which the calls appear. This is relative to the caller
		 * denoted by [`this.from`](#CallHierarchyIncomingCall.from).
		 */
        [DataMember(Name = "fromRanges")]
        public Range[] FromRanges { get; set; }
    }
}
