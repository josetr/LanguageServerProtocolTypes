using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class CallHierarchyIncomingCallsParams : WorkDoneProgressParams, IPartialResultParams
    {
        public CallHierarchyIncomingCallsParams() : base() { }

        [JsonPropertyName("item")]
        public CallHierarchyItem Item { get; set; }

        [JsonPropertyName("partialResultToken")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
