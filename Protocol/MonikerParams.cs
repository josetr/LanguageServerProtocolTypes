using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class MonikerParams : TextDocumentPositionParams, IWorkDoneProgressParams, IPartialResultParams
    {
        public MonikerParams() { }

        [JsonPropertyName("workDoneToken")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, int> WorkDoneToken { get; set; }

        [JsonPropertyName("partialResultToken")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
