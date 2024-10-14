using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DidChangeWatchedFilesParams
    {
        public DidChangeWatchedFilesParams() { }

        /**
         * The actual file events.
         */
        [JsonPropertyName("changes")]
        public required FileEvent[] Changes { get; set; }
    }
}
