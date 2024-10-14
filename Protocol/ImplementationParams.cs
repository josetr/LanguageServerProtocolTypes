using System.Runtime.Serialization;

namespace LspTypes
{
    public class ImplementationParams : TextDocumentPositionParams, IWorkDoneProgressParams, IPartialResultParams
    {
        public ImplementationParams() : base() { }

        [JsonPropertyName("workDoneToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<string, int> WorkDoneToken { get; set; }

        [JsonPropertyName("partialResultToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
