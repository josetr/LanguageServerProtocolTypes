using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DocumentHighlightRegistrationOptions : TextDocumentRegistrationOptions, IDocumentHighlightOptions
    {
        public DocumentHighlightRegistrationOptions() : base() { }

        [JsonPropertyName("workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
