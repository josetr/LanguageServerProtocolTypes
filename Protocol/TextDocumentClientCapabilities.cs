using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * Text document specific client capabilities.
     */
    public class TextDocumentClientCapabilities
    {
        public TextDocumentClientCapabilities() { }

        [JsonPropertyName("synchronization")]
        public TextDocumentSyncClientCapabilities Synchronization { get; set; }

        /**
         * Capabilities specific to the `textDocument/completion` request.
         */
        [JsonPropertyName("completion")]
        public CompletionClientCapabilities Completion { get; set; }

        /**
         * Capabilities specific to the `textDocument/hover` request.
         */
        [JsonPropertyName("hover")]
        public HoverClientCapabilities Hover { get; set; }

        /**
         * Capabilities specific to the `textDocument/signatureHelp` request.
         */
        [JsonPropertyName("signatureHelp")]
        public SignatureHelpClientCapabilities SignatureHelp { get; set; }

        /**
         * Capabilities specific to the `textDocument/declaration` request.
         *
         * @since 3.14.0
         */
        [JsonPropertyName("declaration")]
        public DeclarationClientCapabilities Declaration { get; set; }

        /**
         * Capabilities specific to the `textDocument/definition` request.
         */
        [JsonPropertyName("definition")]
        public DefinitionClientCapabilities Definition { get; set; }

        /**
         * Capabilities specific to the `textDocument/typeDefinition` request.
         *
         * @since 3.6.0
         */
        [JsonPropertyName("typeDefinition")]
        public TypeDefinitionClientCapabilities TypeDefinition { get; set; }

        /**
         * Capabilities specific to the `textDocument/implementation` request.
         *
         * @since 3.6.0
         */
        [JsonPropertyName("implementation")]
        public ImplementationClientCapabilities Implementation { get; set; }

        /**
         * Capabilities specific to the `textDocument/references` request.
         */
        [JsonPropertyName("references")]
        public ReferenceClientCapabilities References { get; set; }

        /**
         * Capabilities specific to the `textDocument/documentHighlight` request.
         */
        [JsonPropertyName("documentHighlight")]
        public DocumentHighlightClientCapabilities DocumentHighlight { get; set; }

        /**
         * Capabilities specific to the `textDocument/documentSymbol` request.
         */
        [JsonPropertyName("documentSymbol")]
        public DocumentSymbolClientCapabilities DocumentSymbol { get; set; }

        /**
         * Capabilities specific to the `textDocument/codeAction` request.
         */
        [JsonPropertyName("codeAction")]
        public CodeActionClientCapabilities CodeAction { get; set; }

        /**
         * Capabilities specific to the `textDocument/codeLens` request.
         */
        [JsonPropertyName("codeLens")]
        public CodeLensClientCapabilities CodeLens { get; set; }

        /**
         * Capabilities specific to the `textDocument/documentLink` request.
         */
        [JsonPropertyName("documentLink")]
        public DocumentLinkClientCapabilities DocumentLink { get; set; }

        /**
         * Capabilities specific to the `textDocument/documentColor` and the
         * `textDocument/colorPresentation` request.
         *
         * @since 3.6.0
         */
        [JsonPropertyName("colorProvider")]
        public DocumentColorClientCapabilities ColorProvider { get; set; }

        /**
         * Capabilities specific to the `textDocument/formatting` request.
         */
        [JsonPropertyName("formatting")]
        public DocumentFormattingClientCapabilities Formatting { get; set; }

        /**
         * Capabilities specific to the `textDocument/rangeFormatting` request.
         */
        [JsonPropertyName("rangeFormatting")]
        public DocumentRangeFormattingClientCapabilities RangeFormatting { get; set; }

        /** request.
         * Capabilities specific to the `textDocument/onTypeFormatting` request.
         */
        [JsonPropertyName("onTypeFormatting")]
        public DocumentOnTypeFormattingClientCapabilities OnTypeFormatting { get; set; }

        /**
         * Capabilities specific to the `textDocument/rename` request.
         */
        [JsonPropertyName("rename")]
        public RenameClientCapabilities Rename { get; set; }

        /**
         * Capabilities specific to the `textDocument/publishDiagnostics`
	     * notification.
	     */
        [JsonPropertyName("publishDiagnostics")]
        public PublishDiagnosticsClientCapabilities PublishDiagnostics { get; set; }

        /**
         * Capabilities specific to the `textDocument/foldingRange` request.
         *
         * @since 3.10.0
         */
        [JsonPropertyName("foldingRange")]
        public FoldingRangeClientCapabilities FoldingRange { get; set; }

        /**
         * Capabilities specific to the `textDocument/selectionRange` request.
         *
         * @since 3.15.0
         */
        [JsonPropertyName("selectionRange")]
        public SelectionRangeClientCapabilities SelectionRange { get; set; }

        /**
	     * Capabilities specific to the `textDocument/linkedEditingRange` request.
	     *
	     * @since 3.16.0
	     */
        [JsonPropertyName("linkedEditingRange")]
        public LinkedEditingRangeClientCapabilities LinkedEditingRange { get; set; }

        /**
	     * Capabilities specific to the various call hierarchy requests.
	     *
	     * @since 3.16.0
	     */
        [JsonPropertyName("callHierarchy")]
        public CallHierarchyClientCapabilities CallHierarchy { get; set; }

        /**
         * Capabilities specific to the various semantic token requests.
         *
         * @since 3.16.0
         */
        [JsonPropertyName("semanticTokens")]
        public SemanticTokensClientCapabilities SemanticTokens { get; set; }

        /**
         * Capabilities specific to the `textDocument/moniker` request.
         *
         * @since 3.16.0
         */
        [JsonPropertyName("moniker")]
        public MonikerClientCapabilities Moniker { get; set; }
    }
}
