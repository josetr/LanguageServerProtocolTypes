using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DocumentFormattingRegistrationOptions : TextDocumentRegistrationOptions, IDocumentFormattingOptions
    {
        public DocumentFormattingRegistrationOptions() : base() { }

        [JsonPropertyName("workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
