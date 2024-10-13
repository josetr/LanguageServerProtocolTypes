using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class HoverParams : TextDocumentPositionParams, IWorkDoneProgressParams
    {
        public HoverParams() : base() { }

        [JsonPropertyName("workDoneToken")]
        public SumType<string, int> WorkDoneToken { get; set; }
    }
}
