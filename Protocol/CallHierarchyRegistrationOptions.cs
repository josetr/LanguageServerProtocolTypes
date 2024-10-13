using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CallHierarchyRegistrationOptions : TextDocumentRegistrationOptions, ICallHierarchyOptions, IStaticRegistrationOptions
    {
        public CallHierarchyRegistrationOptions() : base() { }

        [DataMember(Name = "workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}