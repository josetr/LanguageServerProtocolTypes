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
        public required SumType<int, string> Token { get; set; }
    }
}
