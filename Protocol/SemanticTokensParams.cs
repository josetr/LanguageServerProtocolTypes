namespace LspTypes
{
    public class SemanticTokensParams : WorkDoneProgressParams, IPartialResultParams
    {
        public SemanticTokensParams() : base() { }

        /**
	     * The text document.
	     */
        [JsonPropertyName("textDocument")]
        public TextDocumentIdentifier TextDocument { get; set; }

        [JsonPropertyName("partialResultToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
