namespace LspTypes
{
    public class TypeDefinitionParams : TextDocumentPositionParams, IWorkDoneProgressParams, IPartialResultParams
    {
        public TypeDefinitionParams() : base() { }

        [JsonPropertyName("workDoneToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<string, int> WorkDoneToken { get; set; }

        [JsonPropertyName("partialResultToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
