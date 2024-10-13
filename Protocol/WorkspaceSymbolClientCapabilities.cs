using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    public class WorkspaceSymbolClientCapabilities
    {
        public WorkspaceSymbolClientCapabilities() { }

        /**
         * Symbol request supports dynamic registration.
         */
        [JsonPropertyName("dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }

        /**
         * Specific capabilities for the `SymbolKind` in the `workspace/symbol`
	     * request.
	     */
        [JsonPropertyName("symbolKind")]
        public _WorkspaceSymbolClientCapabilities_SymbolKind SymbolKind { get; set; }

        /**
         * The client supports tags on `SymbolInformation`.
         * Clients supporting tags have to handle unknown tags gracefully.
         *
         * @since 3.16.0
         */
        [JsonPropertyName("tagSupport")]
        public _WorkspaceSymbolClientCapabilities_TagSupport TagSupport { get; set; }
    }
}