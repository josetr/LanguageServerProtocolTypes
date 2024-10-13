using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DidChangeWorkspaceFoldersParams
    {
        public DidChangeWorkspaceFoldersParams() { }

        /**
         * The actual workspace folder change event.
         */
        [JsonPropertyName("event")]
        [JsonProperty(Required = Required.Always)]
        public WorkspaceFoldersChangeEvent Event { get; set; }
    }
}
