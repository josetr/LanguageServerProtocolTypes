using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class ProgressParams<T>
    {
        public ProgressParams() { }

        /**
         * The progress token provided by the client or server.
         */
        [JsonPropertyName("token")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public required SumType<string, int> Token { get; set; }

        /**
         * The progress data.
         */
        [JsonPropertyName("value")]
        public required T Value { get; set; }
    }
}
