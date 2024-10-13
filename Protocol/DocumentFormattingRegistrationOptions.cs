using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentFormattingRegistrationOptions : TextDocumentRegistrationOptions, IDocumentFormattingOptions
    {
        public DocumentFormattingRegistrationOptions() : base() { }

        [JsonPropertyName("workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
