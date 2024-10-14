namespace LspTypes
{
    public class SignatureHelpParams : TextDocumentPositionParams, IWorkDoneProgressParams
    {
        public SignatureHelpParams() { }

        /**
         * The signature help context. This is only available if the client
	     * specifies to send this using the client capability
	     * `textDocument.signatureHelp.contextSupport === true`
         *
         * @since 3.15.0
         */
        [JsonPropertyName("context")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public SignatureHelpContext Context { get; set; }

        /**
         * An optional token that a server can use to report work done progress.
         */
        [JsonPropertyName("workDoneToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<string, int> WorkDoneToken { get; set; }
    }
}
