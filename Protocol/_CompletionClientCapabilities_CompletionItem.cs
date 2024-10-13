using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    public class _CompletionClientCapabilities_CompletionItem
    {
        public _CompletionClientCapabilities_CompletionItem() { }

        /**
         * Client supports snippets as insert text.
         *
         * A snippet can define tab stops and placeholders with `$1`, `$2`
         * and `${3:foo}`. `$0` defines the final tab stop, it defaults to
         * the end of the snippet. Placeholders with equal identifiers are
		 * linked, that is typing in one will update others too.
         */
        [JsonPropertyName("snippetSupport")]
        public bool? SnippetSupport { get; set; }

        /**
         * Client supports commit characters on a completion item.
         */
        [JsonPropertyName("commitCharactersSupport")]
        public bool? CommitCharactersSupport { get; set; }

        /**
         * Client supports the follow content formats for the documentation
         * property. The order describes the preferred format of the client.
         */
        [JsonPropertyName("documentationFormat")]
        public MarkupKind[] DocumentationFormat { get; set; }

        /**
         * Client supports the deprecated property on a completion item.
         */
        [JsonPropertyName("deprecatedSupport")]
        public bool? DeprecatedSupport { get; set; }

        /**
         * Client supports the preselect property on a completion item.
         */
        [JsonPropertyName("preselectSupport")]
        public bool? PreselectSupport { get; set; }

        /**
         * Client supports the tag property on a completion item. Clients
		 * supporting tags have to handle unknown tags gracefully. Clients
		 * especially need to preserve unknown tags when sending a completion
		 * item back to the server in a resolve call.
         *
         * @since 3.15.0
         */
        [JsonPropertyName("tagSupport")]
        public _CompletionClientCapabilities_CompletionItem_TagSupport TagSupport { get; set; }

        /**
         * Client supports insert replace edit to control different behavior if
         * a completion item is inserted in the text or should replace text.
         *
         * @since 3.16.0
         */
        [JsonPropertyName("insertReplaceSupport")]
        public bool? InsertReplaceSupport { get; set; }

        /**
		 * Indicates which properties a client can resolve lazily on a
		 * completion item. Before version 3.16.0 only the predefined properties
		 * `documentation` and `details` could be resolved lazily.
		 *
		 * @since 3.16.0
		 */
        [JsonPropertyName("resolveSupport")]
        public _CompletionClientCapabilities_CompletionItem_ResolveSupport ResolveSupport { get; set; }

        /**
         * The client supports the `insertTextMode` property on
         * a completion item to override the whitespace handling mode
         * as defined by the client (see `insertTextMode`).
         *
         * @since 3.16.0
         */
        [JsonPropertyName("insertTextModeSupport")]
        public _CompletionClientCapabilities_CompletionItem_InsertTextModeSupport InsertTextModeSupport { get; set; }
    }
}
