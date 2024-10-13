using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class ReferenceRegistrationOptions : TextDocumentRegistrationOptions, IReferenceOptions
    {
        public ReferenceRegistrationOptions() : base() { }

        [DataMember(Name = "workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
