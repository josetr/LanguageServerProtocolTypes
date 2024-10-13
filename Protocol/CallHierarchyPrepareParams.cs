using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class CallHierarchyPrepareParams : TextDocumentPositionParams, IWorkDoneProgressParams
    {
        public CallHierarchyPrepareParams() { }

        [JsonPropertyName("workDoneToken")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, int> WorkDoneToken { get; set; }

    }
}
