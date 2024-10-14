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
        public required WorkspaceFoldersChangeEvent Event { get; set; }
    }
}
