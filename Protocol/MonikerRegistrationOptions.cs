using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class MonikerRegistrationOptions : TextDocumentRegistrationOptions, IMonikerOptions
    {
        public MonikerRegistrationOptions() : base() { }

        [JsonPropertyName("workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
