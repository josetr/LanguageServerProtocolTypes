namespace LspTypes
{
    public class CallHierarchyPrepareParams : TextDocumentPositionParams, IWorkDoneProgressParams
    {
        public CallHierarchyPrepareParams() { }

        [JsonPropertyName("workDoneToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<string, int> WorkDoneToken { get; set; }

    }
}
