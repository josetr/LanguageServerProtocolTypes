namespace LspTypes
{
    public class PublishDiagnosticsClientCapabilities
    {
        public PublishDiagnosticsClientCapabilities() { }

        /**
         * Whether the clients accepts diagnostics with related information.
         */
        [JsonPropertyName("relatedInformation")]
        public bool? RelatedInformation { get; set; }

        /**
         * Client supports the tag property to provide meta data about a diagnostic.
         * Clients supporting tags have to handle unknown tags gracefully.
         *
         * @since 3.15.0
         */
        [JsonPropertyName("tagSupport")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public _PublishDiagnosticsClientCapabilities_TagSupport TagSupport { get; set; }

        /**
         * Whether the client interprets the version property of the
         * `textDocument/publishDiagnostics` notification's parameter.
         *
         * @since 3.15.0
         */
        [JsonPropertyName("versionSupport")]
        public bool? VersionSupport { get; set; }

        /**
	     * Client supports a codeDescription property
         *
	     * @since 3.16.0
	     */
        [JsonPropertyName("codeDescriptionSupport")]
        public bool? CodeDescriptionSupport { get; set; }

        /**
	     * Whether code action supports the `data` property which is
	     * preserved between a `textDocument/publishDiagnostics` and
	     * `textDocument/codeAction` request.
	     *
	     * @since 3.16.0
	     */
        [JsonPropertyName("dataSupport")]
        public bool? DataSupport { get; set; }
    }
}