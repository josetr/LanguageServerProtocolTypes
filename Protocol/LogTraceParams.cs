using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class LogTraceParams
    {
        public LogTraceParams() { }

        /**
		 * The message to be logged.
		 */
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /**
		 * Additional information that can be computed if the `trace` configuration
		 * is set to `'verbose'`
		 */
        [JsonPropertyName("verbose")]
        public string Verbose { get; set; }
    }
}
