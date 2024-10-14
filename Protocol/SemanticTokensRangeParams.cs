namespace LspTypes
{
    public class SemanticTokensRangeParams : WorkDoneProgressParams, IPartialResultParams
    {
        public SemanticTokensRangeParams() : base() { }

        /**
	     * The text document.
	     */
        [JsonPropertyName("textDocument")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
         * The range the semantic tokens are requested for.
         */
        [JsonPropertyName("range")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Range Range { get; set; }

        [JsonPropertyName("partialResultToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
