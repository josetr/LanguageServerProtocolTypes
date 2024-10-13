using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    public class SignatureHelpRegistrationOptions : TextDocumentRegistrationOptions, ISignatureHelpOptions, IWorkDoneProgressOptions
    {
        public SignatureHelpRegistrationOptions() { }

        [JsonPropertyName("triggerCharacters")]
        public string[] TriggerCharacters { get; set; }

        [JsonPropertyName("retriggerCharacters")]
        public string[] RetriggerCharacters { get; set; }

        [JsonPropertyName("workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
