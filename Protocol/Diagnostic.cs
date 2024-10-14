using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class Diagnostic
    {
        public Diagnostic() { }

        /**
         * The range at which the message applies.
         */
        [JsonPropertyName("range")]
        public required Range Range { get; set; }

        /**
         * The diagnostic's severity. Can be omitted. If omitted it is up to the
         * client to interpret diagnostics as error, warning, info or hint.
         */
        [JsonPropertyName("severity")]
        public DiagnosticSeverity Severity { get; set; }

        /**
         * The diagnostic's code, which might appear in the user interface.
         */
        [JsonPropertyName("code")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, int> Code { get; set; }

        /**
	     * An optional property to describe the error code.
	     *
	     * @since 3.16.0
	     */
        [JsonPropertyName("codeDescription")]
        public CodeDescription CodeDescription { get; set; }

        /**
         * A human-readable string describing the source of this
         * diagnostic, e.g. 'typescript' or 'super lint'.
         */
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /**
         * The diagnostic's message.
         */
        [JsonPropertyName("message")]
        public required string Message { get; set; }

        /**
         * Additional metadata about the diagnostic.
         *
         * @since 3.15.0
         */
        [JsonPropertyName("tags")]
        public DiagnosticTag[] Tags { get; set; }

        /**
         * An array of related diagnostic information, e.g. when symbol-names within
         * a scope collide all definitions can be marked via this property.
         */
        [JsonPropertyName("relatedInformation")]
        public DiagnosticRelatedInformation[] RelatedInformation { get; set; }

        /**
           * A data entry field that is preserved between a
           * `textDocument/publishDiagnostics` notification and
           * `textDocument/codeAction` request.
           *
           * @since 3.16.0
           */
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }
}
