using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class LinkedEditingRangeRegistrationOptions : TextDocumentRegistrationOptions, ILinkedEditingRangeOptions, IStaticRegistrationOptions
    {
        public LinkedEditingRangeRegistrationOptions() { }

        [JsonPropertyName("workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
