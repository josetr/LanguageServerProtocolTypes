using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    public class _ClientCapabilities_Workspace
    {
        public _ClientCapabilities_Workspace() { }

        /**
         * The client supports applying batch edits
         * to the workspace by supporting the request
         * 'workspace/applyEdit'
         */
        [JsonPropertyName("applyEdit")]
        public bool? ApplyEdit { get; set; }

        /**
         * Capabilities specific to `WorkspaceEdit`s
         */
        [JsonPropertyName("workspaceEdit")]
        public WorkspaceEditClientCapabilities WorkspaceEdit { get; set; }

        /**
         * Capabilities specific to the `workspace/didChangeConfiguration`
		 * notification.
         */
        [JsonPropertyName("didChangeConfiguration")]
        public DidChangeConfigurationClientCapabilities DidChangeConfiguration { get; set; }

        /**
         * Capabilities specific to the `workspace/didChangeWatchedFiles`
		 * notification.
		 */
        [JsonPropertyName("didChangeWatchedFiles")]
        public DidChangeWatchedFilesClientCapabilities DidChangeWatchedFiles { get; set; }

        /**
         * Capabilities specific to the `workspace/symbol` request.
         */
        [JsonPropertyName("symbol")]
        public WorkspaceSymbolClientCapabilities Symbol { get; set; }

        /**
         * Capabilities specific to the `workspace/executeCommand` request.
         */
        [JsonPropertyName("executeCommand")]
        public ExecuteCommandClientCapabilities ExecuteCommand { get; set; }

        /**
         * The client has support for workspace folders.
         *
         * @since 3.6.0
         */
        [JsonPropertyName("workspaceFolders")]
        public bool? WorkspaceFolders { get; set; }

        /**
         * The client supports `workspace/configuration` requests.
         *
         * @since 3.6.0
         */
        [JsonPropertyName("configuration")]
        public bool? Configuration { get; set; }

        /**
         * Capabilities specific to the semantic token requests scoped to the
         * workspace.
         *
         * @since 3.16.0
         */
        [JsonPropertyName("semanticTokens")]
        public SemanticTokensWorkspaceClientCapabilities SemanticTokens { get; set; }

        /**
		 * Capabilities specific to the code lens requests scoped to the
		 * workspace.
		 *
		 * @since 3.16.0
		 */
        [JsonPropertyName("codeLens")]
        public CodeLensWorkspaceClientCapabilities CodeLens { get; set; }

        /**
		 * The client has support for file requests/notifications.
		 *
		 * @since 3.16.0
		 */
        [JsonPropertyName("fileOperations")]
        public _ClientCapabilities_Workspace_FileOperations fileOperations { get; set; }

    }
}