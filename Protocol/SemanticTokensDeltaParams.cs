namespace LspTypes
{
    public class SemanticTokensDeltaParams : WorkDoneProgressParams, IPartialResultParams
    {
        public SemanticTokensDeltaParams() { }

        /**
	     * The text document.
	     */
        [JsonPropertyName("textDocument")]
        public required TextDocumentIdentifier TextDocument { get; set; }

        /**
	     * The result id of a previous response. The result Id can either point to
	     * a full response or a delta response depending on what was received last.
	     */
        [JsonPropertyName("previousResultId")]
        public required string PreviousResultId { get; set; }

        /**
         * An optional token that a server can use to report partial results (e.g. streaming) to
         * the client.
         */
        [JsonPropertyName("partialResultToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
