using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class CodeActionRegistrationOptions : TextDocumentRegistrationOptions, ICodeActionOptions
    {
        public CodeActionRegistrationOptions() { }

        [JsonPropertyName("codeActionKinds")]
        public CodeActionKind[] CodeActionKinds { get; set; }

        [JsonPropertyName("resolveProvider")]
        public bool? WorkDoneProgress { get; set; }
    }
}
