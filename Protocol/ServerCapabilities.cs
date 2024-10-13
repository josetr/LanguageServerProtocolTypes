using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class ServerCapabilities
    {
        public ServerCapabilities() { }

        /**
         * Defines how text documents are synced. Is either a detailed structure
	     * defining each notification or for backwards compatibility the
	     * TextDocumentSyncKind number. If omitted it defaults to
	     * `TextDocumentSyncKind.None`.
         */
        [JsonPropertyName("textDocumentSync")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<TextDocumentSyncOptions, TextDocumentSyncKind> TextDocumentSync { get; set; }

        /**
         * The server provides completion support.
         */
        [JsonPropertyName("completionProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CompletionOptions CompletionProvider { get; set; }

        /**
         * The server provides hover support.
         */
        [JsonPropertyName("hoverProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, HoverOptions> HoverProvider { get; set; }

        /**
         * The server provides signature help support.
         */
        [JsonPropertyName("signatureHelpProvider")]
        public SignatureHelpOptions SignatureHelpProvider { get; set; }

        /**
         * The server provides go to declaration support.
         *
         * @since 3.14.0
         */
        [JsonPropertyName("declarationProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, DeclarationOptions, DeclarationRegistrationOptions> DeclarationProvider { get; set; }

        /**
         * The server provides goto definition support.
         */
        [JsonPropertyName("definitionProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, DefinitionOptions> DefinitionProvider { get; set; }

        /**
         * The server provides goto type definition support.
         *
         * @since 3.6.0
         */
        [JsonPropertyName("typeDefinitionProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, TypeDefinitionOptions, TypeDefinitionRegistrationOptions> TypeDefinitionProvider { get; set; }

        /**
         * The server provides goto implementation support.
         *
         * @since 3.6.0
         */
        [JsonPropertyName("implementationProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, ImplementationOptions, ImplementationRegistrationOptions> ImplementationProvider { get; set; }

        /**
         * The server provides find references support.
         */
        [JsonPropertyName("referencesProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, ReferenceOptions> ReferencesProvider { get; set; }

        /**
         * The server provides document highlight support.
         */
        [JsonPropertyName("documentHighlightProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, DocumentHighlightOptions> DocumentHighlightProvider { get; set; }

        /**
         * The server provides document symbol support.
         */
        [JsonPropertyName("documentSymbolProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, DocumentSymbolOptions> DocumentSymbolProvider { get; set; }

        /**
         * The server provides code actions. The `CodeActionOptions` return type is
	     * only valid if the client signals code action literal support via the
	     * property `textDocument.codeAction.codeActionLiteralSupport`.
         */
        [JsonPropertyName("codeActionProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, CodeActionOptions> CodeActionProvider { get; set; }

        /**
         * The server provides code lens.
         */
        [JsonPropertyName("codeLensProvider")]
        public CodeLensOptions CodeLensProvider { get; set; }

        /**
         * The server provides document link support.
         */
        [JsonPropertyName("documentLinkProvider")]
        public DocumentLinkOptions DocumentLinkProvider { get; set; }

        /**
         * The server provides color provider support.
         *
         * @since 3.6.0
         */
        [JsonPropertyName("colorProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, DocumentColorOptions, DocumentColorRegistrationOptions> ColorProvider { get; set; }

        /**
         * The server provides document formatting.
         */
        [JsonPropertyName("documentFormattingProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, DocumentFormattingOptions> DocumentFormattingProvider { get; set; }

        /**
         * The server provides document range formatting.
         */
        [JsonPropertyName("documentRangeFormattingProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, DocumentRangeFormattingOptions> DocumentRangeFormattingProvider { get; set; }

        /**
         * The server provides document formatting on typing.
         */
        [JsonPropertyName("documentOnTypeFormattingProvider")]
        public DocumentOnTypeFormattingOptions DocumentOnTypeFormattingProvider { get; set; }

        /**
         * The server provides rename support. RenameOptions may only be
         * specified if the client states that it supports
         * `prepareSupport` in its initial `initialize` request.
         */
        [JsonPropertyName("renameProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, RenameOptions> RenameProvider { get; set; }

        /**
         * The server provides folding provider support.
         *
         * @since 3.10.0
         */
        [JsonPropertyName("foldingRangeProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, FoldingRangeOptions, FoldingRangeRegistrationOptions> FoldingRangeProvider { get; set; }

        /**
         * The server provides execute command support.
         */
        [JsonPropertyName("executeCommandProvider")]
        public ExecuteCommandOptions ExecuteCommandProvider { get; set; }

        /**
         * The server provides selection range support.
         *
         * @since 3.15.0
         */
        [JsonPropertyName("selectionRangeProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, SelectionRangeOptions, SelectionRangeRegistrationOptions> SelectionRangeProvider { get; set; }

        /**
         * The server provides linked editing range support.
	     *
	     * @since 3.16.0
	     */
        [JsonPropertyName("linkedEditingRangeProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, LinkedEditingRangeOptions, LinkedEditingRangeRegistrationOptions> LinkedEditingRangeProvider { get; set; }

        /**
	     * The server provides call hierarchy support.
	     *
	     * @since 3.16.0
	     */
        [JsonPropertyName("callHierarchyProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, CallHierarchyOptions, CallHierarchyRegistrationOptions> CallHierarchyProvider { get; set; }

        /**
         * The server provides semantic tokens support.
         *
         * @since 3.16.0
         */
        [JsonPropertyName("semanticTokensProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<SemanticTokensOptions, SemanticTokensRegistrationOptions> SemanticTokensProvider { get; set; }

        /**
	     * Whether server provides moniker support.
	     *
	     * @since 3.16.0
	     */
        [JsonPropertyName("monikerProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, MonikerOptions, MonikerRegistrationOptions> MonikerProvider { get; set; }

        /**
         * The server provides workspace symbol support.
         */
        [JsonPropertyName("workspaceSymbolProvider")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<bool, WorkspaceSymbolOptions> WorkspaceSymbolProvider { get; set; }

        /**
         * Workspace specific server capabilities
         */
        [JsonPropertyName("workspace")]
        public _ServerCapabilities_Workspace Workspace { get; set; }

        /**
         * Experimental server capabilities.
         */
        [JsonPropertyName("experimental")]
        public object Experimental { get; set; }
    }
}