using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentSymbolRegistrationOptions : TextDocumentRegistrationOptions, IDocumentSymbolOptions
    {
        public DocumentSymbolRegistrationOptions() : base() { }

        [DataMember(Name = "label")]
        public string Label { get; set; }

        [DataMember(Name = "workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
