namespace LspTypes
{
    public class RenameParams : TextDocumentPositionParams, IWorkDoneProgressParams
    {
        public RenameParams() { }

        /**
         * The new name of the symbol. If the given name is not valid the
         * request must return a [ResponseError](#ResponseError) with an
         * appropriate message set.
         */
        [JsonPropertyName("newName")]
        public string NewName { get; set; }

        /**
         * An optional token that a server can use to report work done progress.
         */
        [JsonPropertyName("workDoneToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<string, int> WorkDoneToken { get; set; }
    }
}
