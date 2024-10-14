namespace LspTypes
{
    public class DocumentSymbolParams : WorkDoneProgressParams, IPartialResultParams
    {
        public DocumentSymbolParams() { }

        /**
         * The text document.
         */
        [JsonPropertyName("textDocument")]
        public required TextDocumentIdentifier TextDocument { get; set; }

        /**
         * An optional token that a server can use to report partial results (e.g. streaming) to
         * the client.
         */
        [JsonPropertyName("partialResultToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
