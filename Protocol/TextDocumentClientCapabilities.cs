using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * Text document specific client capabilities.
     */
    [DataContract]
    public class TextDocumentClientCapabilities
    {
        public TextDocumentClientCapabilities() { }

        [DataMember(Name = "synchronization")]
        public TextDocumentSyncClientCapabilities Synchronization { get; set; }

        /**
         * Capabilities specific to the `textDocument/completion` request.
         */
        [DataMember(Name = "completion")]
        public CompletionClientCapabilities Completion { get; set; }

        /**
         * Capabilities specific to the `textDocument/hover` request.
         */
        [DataMember(Name = "hover")]
        public HoverClientCapabilities Hover { get; set; }

        /**
         * Capabilities specific to the `textDocument/signatureHelp` request.
         */
        [DataMember(Name = "signatureHelp")]
        public SignatureHelpClientCapabilities SignatureHelp { get; set; }

        /**
         * Capabilities specific to the `textDocument/declaration` request.
         *
         * @since 3.14.0
         */
        [DataMember(Name = "declaration")]
        public DeclarationClientCapabilities Declaration { get; set; }

        /**
         * Capabilities specific to the `textDocument/definition` request.
         */
        [DataMember(Name = "definition")]
        public DefinitionClientCapabilities Definition { get; set; }

        /**
         * Capabilities specific to the `textDocument/typeDefinition` request.
         *
         * @since 3.6.0
         */
        [DataMember(Name = "typeDefinition")]
        public TypeDefinitionClientCapabilities TypeDefinition { get; set; }

        /**
         * Capabilities specific to the `textDocument/implementation` request.
         *
         * @since 3.6.0
         */
        [DataMember(Name = "implementation")]
        public ImplementationClientCapabilities Implementation { get; set; }

        /**
         * Capabilities specific to the `textDocument/references` request.
         */
        [DataMember(Name = "references")]
        public ReferenceClientCapabilities References { get; set; }

        /**
         * Capabilities specific to the `textDocument/documentHighlight` request.
         */
        [DataMember(Name = "documentHighlight")]
        public DocumentHighlightClientCapabilities DocumentHighlight { get; set; }

        /**
         * Capabilities specific to the `textDocument/documentSymbol` request.
         */
        [DataMember(Name = "documentSymbol")]
        public DocumentSymbolClientCapabilities DocumentSymbol { get; set; }

        /**
         * Capabilities specific to the `textDocument/codeAction` request.
         */
        [DataMember(Name = "codeAction")]
        public CodeActionClientCapabilities CodeAction { get; set; }

        /**
         * Capabilities specific to the `textDocument/codeLens` request.
         */
        [DataMember(Name = "codeLens")]
        public CodeLensClientCapabilities CodeLens { get; set; }

        /**
         * Capabilities specific to the `textDocument/documentLink` request.
         */
        [DataMember(Name = "documentLink")]
        public DocumentLinkClientCapabilities DocumentLink { get; set; }

        /**
         * Capabilities specific to the `textDocument/documentColor` and the
         * `textDocument/colorPresentation` request.
         *
         * @since 3.6.0
         */
        [DataMember(Name = "colorProvider")]
        public DocumentColorClientCapabilities ColorProvider { get; set; }

        /**
         * Capabilities specific to the `textDocument/formatting` request.
         */
        [DataMember(Name = "formatting")]
        public DocumentFormattingClientCapabilities Formatting { get; set; }

        /**
         * Capabilities specific to the `textDocument/rangeFormatting` request.
         */
        [DataMember(Name = "rangeFormatting")]
        public DocumentRangeFormattingClientCapabilities RangeFormatting { get; set; }

        /** request.
         * Capabilities specific to the `textDocument/onTypeFormatting` request.
         */
        [DataMember(Name = "onTypeFormatting")]
        public DocumentOnTypeFormattingClientCapabilities OnTypeFormatting { get; set; }

        /**
         * Capabilities specific to the `textDocument/rename` request.
         */
        [DataMember(Name = "rename")]
        public RenameClientCapabilities Rename { get; set; }

        /**
         * Capabilities specific to the `textDocument/publishDiagnostics`
	     * notification.
	     */
        [DataMember(Name = "publishDiagnostics")]
        public PublishDiagnosticsClientCapabilities PublishDiagnostics { get; set; }

        /**
         * Capabilities specific to the `textDocument/foldingRange` request.
         *
         * @since 3.10.0
         */
        [DataMember(Name = "foldingRange")]
        public FoldingRangeClientCapabilities FoldingRange { get; set; }

        /**
         * Capabilities specific to the `textDocument/selectionRange` request.
         *
         * @since 3.15.0
         */
        [DataMember(Name = "selectionRange")]
        public SelectionRangeClientCapabilities SelectionRange { get; set; }

        /**
	     * Capabilities specific to the `textDocument/linkedEditingRange` request.
	     *
	     * @since 3.16.0
	     */
        [DataMember(Name = "linkedEditingRange")]
        public LinkedEditingRangeClientCapabilities LinkedEditingRange { get; set; }

        /**
	     * Capabilities specific to the various call hierarchy requests.
	     *
	     * @since 3.16.0
	     */
        [DataMember(Name = "callHierarchy")]
        public CallHierarchyClientCapabilities CallHierarchy { get; set; }

        /**
         * Capabilities specific to the various semantic token requests.
         *
         * @since 3.16.0
         */
        [DataMember(Name = "semanticTokens")]
        public SemanticTokensClientCapabilities SemanticTokens { get; set; }

        /**
         * Capabilities specific to the `textDocument/moniker` request.
         *
         * @since 3.16.0
         */
        [DataMember(Name = "moniker")]
        public MonikerClientCapabilities Moniker { get; set; }
    }
}
