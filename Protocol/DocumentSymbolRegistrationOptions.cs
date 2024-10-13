using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentSymbolRegistrationOptions : TextDocumentRegistrationOptions, IDocumentSymbolOptions
    {
        public DocumentSymbolRegistrationOptions() : base() { }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
