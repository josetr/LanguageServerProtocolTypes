using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DocumentSymbolClientCapabilities
    {
        public DocumentSymbolClientCapabilities() { }

        /**
         * Whether document symbol supports dynamic registration.
         */
        [JsonPropertyName("dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }

        /**
         * Specific capabilities for the `SymbolKind` in the
	     * `textDocument/documentSymbol` request.
	     */
        [JsonPropertyName("symbolKind")]
        public _DocumentSymbolClientCapabilities_SymbolKind SymbolKind { get; set; }

        /**
         * The client supports hierarchical document symbols.
         */
        [JsonPropertyName("hierarchicalDocumentSymbolSupport")]
        public bool? HierarchicalDocumentSymbolSupport { get; set; }

        /**
         * The client supports tags on `SymbolInformation`. Tags are supported on
         * `DocumentSymbol` if `hierarchicalDocumentSymbolSupport` is set to true.
         * Clients supporting tags have to handle unknown tags gracefully.
         *
         * @since 3.16.0
         */
        [JsonPropertyName("tagSupport")]
        public _DocumentSymbolClientCapabilities_TagSupport TagSupport { get; set; }

        /**
         * The client supports an additional label presented in the UI when
         * registering a document symbol provider.
         *
         * @since 3.16.0
         */
        [JsonPropertyName("labelSupport")]
        public bool? LabelSupport { get; set; }
    }
}
