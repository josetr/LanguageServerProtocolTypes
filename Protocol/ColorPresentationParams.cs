namespace LspTypes
{
    /**
     * Params for the CodeActionRequest
     */
    public class ColorPresentationParams : WorkDoneProgressParams, IPartialResultParams
    {
        public ColorPresentationParams() { }

        /**
	     * The text document.
	     */
        [JsonPropertyName("textDocument")]
        public required TextDocumentIdentifier TextDocument { get; set; }

        /**
	     * The color information to request presentations for.
	     */
        [JsonPropertyName("color")]
        public required Color Color { get; set; }

        /**
	     * The range where the color would be inserted. Serves as a context.
	     */
        [JsonPropertyName("range")]
        public required Range Range { get; set; }

        [JsonPropertyName("partialResultToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
