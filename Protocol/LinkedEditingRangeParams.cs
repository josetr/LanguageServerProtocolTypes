namespace LspTypes
{
    public class LinkedEditingRangeParams : TextDocumentPositionParams, IWorkDoneProgressParams
    {
        public LinkedEditingRangeParams() { }

        [JsonPropertyName("workDoneToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<string, int> WorkDoneToken { get; set; }
    }
}
