using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class _InitializeResults_ServerInfo
    {
        public _InitializeResults_ServerInfo() { }

        /**
         * The name of the server as defined by the server.
         */
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        /**
         * The server's version as defined by the server.
         */
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
