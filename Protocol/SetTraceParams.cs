using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SetTraceParams
    {
        public SetTraceParams() { }

        /**
		 * The new value that should be assigned to the trace setting.
		 */
        [JsonPropertyName("value")]
        public TraceValue Value { get; set; }
    }
}
