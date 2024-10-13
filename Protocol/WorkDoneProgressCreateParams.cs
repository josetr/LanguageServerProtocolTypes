using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    public class WorkDoneProgressCreateParams
    {
        public WorkDoneProgressCreateParams() { }

        /**
	     * The token to be used to report progress.
	     */
        [JsonPropertyName("token")]
        [JsonProperty(Required = Required.Always)]
        public SumType<int, string> Token { get; set; }
    }
}
