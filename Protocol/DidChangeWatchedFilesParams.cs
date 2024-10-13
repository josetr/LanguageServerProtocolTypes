using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DidChangeWatchedFilesParams
    {
        public DidChangeWatchedFilesParams() { }

        /**
         * The actual file events.
         */
        [JsonPropertyName("changes")]
        [JsonProperty(Required = Required.Always)]
        public FileEvent[] Changes { get; set; }
    }
}
