using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentHighlightRegistrationOptions : TextDocumentRegistrationOptions, IDocumentHighlightOptions
    {
        public DocumentHighlightRegistrationOptions() : base() { }

        [DataMember(Name = "workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
