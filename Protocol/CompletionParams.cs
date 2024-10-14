namespace LspTypes
{
    public class CompletionParams : TextDocumentPositionParams, IWorkDoneProgressParams, IPartialResultParams
    {
        public CompletionParams() { }

        /**
         * The completion context. This is only available if the client specifies
         * to send this using the client capability
	     * `completion.contextSupport === true`
         */
        [JsonPropertyName("context")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public CompletionContext Context { get; set; }

        /**
         * An optional token that a server can use to report work done progress.
         */
        [JsonPropertyName("workDoneToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<string, int> WorkDoneToken { get; set; }

        /**
         * An optional token that a server can use to report partial results (e.g. streaming) to
         * the client.
         */
        [JsonPropertyName("partialResultToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
