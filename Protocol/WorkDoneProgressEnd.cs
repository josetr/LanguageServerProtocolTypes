using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class WorkDoneProgressEnd
    {
        public WorkDoneProgressEnd() { }

        [JsonPropertyName("kind")]
        [JsonProperty(Required = Required.Always)]
        public string Kind { get; set; }

        /**
         * Optional, a final message indicating to for example indicate the outcome
         * of the operation.
         */
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
