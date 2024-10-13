using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class MonikerRegistrationOptions : TextDocumentRegistrationOptions, IMonikerOptions
    {
        public MonikerRegistrationOptions() : base() { }

        [DataMember(Name = "workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
