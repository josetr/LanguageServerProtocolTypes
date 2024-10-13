using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class LinkedEditingRangeParams : TextDocumentPositionParams, IWorkDoneProgressParams
    {
        public LinkedEditingRangeParams() { }

        [JsonPropertyName("workDoneToken")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, int> WorkDoneToken { get; set; }
    }
}
