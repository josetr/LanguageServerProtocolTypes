namespace LspTypes
{
    public class DocumentColorParams : WorkDoneProgressParams, IPartialResultParams
    {
        public DocumentColorParams() : base() { }

        /**
	     * The text document.
	     */
        [JsonPropertyName("textDocument")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public TextDocumentIdentifier TextDocument { get; set; }

        [JsonPropertyName("partialResultToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<int, string> PartialResultToken { get; set; }

    }
}
