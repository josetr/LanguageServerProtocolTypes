using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /*
     * Parameter for the initialize request.
     * The initialize request is sent as the first request from the
     * client to the server.
     * https://microsoft.github.io/language-server-protocol/specifications/specification-3-16/#initialize
     */
    public class ClientCapabilities
    {
        public ClientCapabilities() { }

        /**
         * Workspace specific client capabilities.
         */
        [JsonPropertyName("workspace")]
        public _ClientCapabilities_Workspace Workspace { get; set; }

        /**
         * Text document specific client capabilities.
         */
        [JsonPropertyName("textDocument")]
        public TextDocumentClientCapabilities TextDocument { get; set; }

        /**
         * Window specific client capabilities.
         */
        [JsonPropertyName("window")]
        public _ClientCapabilities_Window Window { get; set; }

        /**
         * General client capabilities.
         *
         * @since 3.16.0
         */
        [JsonPropertyName("general")]
        public _ClientCapabilities_General General { get; set; }

        /**
         * Experimental client capabilities.
         */
        [JsonPropertyName("experimental")]
        public object Experimental { get; set; }
    }
}
