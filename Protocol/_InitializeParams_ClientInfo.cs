using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class _InitializeParams_ClientInfo
    {
        public _InitializeParams_ClientInfo() { }

        /**
         * The name of the client as defined by the client.
         */
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        /**
         * The client's version as defined by the client.
         */
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
