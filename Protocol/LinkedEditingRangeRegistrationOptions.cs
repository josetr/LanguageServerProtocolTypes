using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class LinkedEditingRangeRegistrationOptions : TextDocumentRegistrationOptions, ILinkedEditingRangeOptions, IStaticRegistrationOptions
    {
        public LinkedEditingRangeRegistrationOptions() { }

        [JsonPropertyName("workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
