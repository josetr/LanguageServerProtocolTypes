using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class ReferenceRegistrationOptions : TextDocumentRegistrationOptions, IReferenceOptions
    {
        public ReferenceRegistrationOptions() : base() { }

        [JsonPropertyName("workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
