using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class WorkspaceEditClientCapabilities
    {
        public WorkspaceEditClientCapabilities() { }

        /**
         * The client supports versioned document changes in `WorkspaceEdit`s
         */
        [JsonPropertyName("documentChanges")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? DocumentChanges { get; set; }

        /**
         * The resource operations the client supports. Clients should at least
         * support 'create', 'rename' and 'delete' files and folders.
         *
         * @since 3.13.0
         */
        [JsonPropertyName("resourceOperations")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ResourceOperationKind[] ResourceOperations;

        /**
         * The failure handling strategy of a client if applying the workspace edit
         * fails.
         *
         * @since 3.13.0
         */
        [JsonPropertyName("failureHandling")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FailureHandlingKind FailureHandling;

        /**
         * Whether the client normalizes line endings to the client specific
         * setting.
         * If set to `true` the client will normalize line ending characters
         * in a workspace edit to the client specific new line character(s).
         *
         * @since 3.16.0
         */
        [JsonPropertyName("normalizesLineEndings")]
        public bool? NormalizesLineEndings { get; set; }

        /**
	     * Whether the client in general supports change annotations on text edits,
	     * create file, rename file and delete file changes.
	     *
	     * @since 3.16.0
	     */
        [JsonPropertyName("changeAnnotationSupport")]
        public _WorkspaceEditClientCapabilities_ChangeAnnotationSupport ChangeAnnotationSupport { get; set; }
    }
}
