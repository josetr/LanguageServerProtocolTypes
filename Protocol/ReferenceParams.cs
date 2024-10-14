namespace LspTypes
{
    public class ReferenceParams : TextDocumentPositionParams, IWorkDoneProgressParams, IPartialResultParams
    {
        public ReferenceParams() { }

        [JsonPropertyName("context")]
        public ReferenceContext Context { get; set; }

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
