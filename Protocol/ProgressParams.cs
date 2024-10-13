using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class ProgressParams<T>
    {
        public ProgressParams() { }

        /**
         * The progress token provided by the client or server.
         */
        [JsonPropertyName("token")]
        [JsonProperty(Required = Required.Always, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, int> Token { get; set; }

        /**
         * The progress data.
         */
        [JsonPropertyName("value")]
        [JsonProperty(Required = Required.Always)]
        public T Value { get; set; }
    }
}
