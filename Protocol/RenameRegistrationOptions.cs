using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class RenameRegistrationOptions : TextDocumentRegistrationOptions, IRenameOptions
    {
        public RenameRegistrationOptions() : base() { }

        [JsonPropertyName("prepareProvider")]
        public bool? PrepareProvider { get; set; }

        [JsonPropertyName("workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
