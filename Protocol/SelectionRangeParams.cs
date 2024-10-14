namespace LspTypes
{
    public class SelectionRangeParams : WorkDoneProgressParams, IPartialResultParams
    {
        public SelectionRangeParams() : base() { }

        /**
		 * The text document.
		 */
        [JsonPropertyName("textDocument")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
		 * The positions inside the text document.
		 */
        [JsonPropertyName("positions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Position[] Positions { get; set; }

        [JsonPropertyName("partialResultToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
