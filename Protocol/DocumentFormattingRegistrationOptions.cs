using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentFormattingRegistrationOptions : TextDocumentRegistrationOptions, IDocumentFormattingOptions
    {
        public DocumentFormattingRegistrationOptions() : base() { }

        [DataMember(Name = "workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
