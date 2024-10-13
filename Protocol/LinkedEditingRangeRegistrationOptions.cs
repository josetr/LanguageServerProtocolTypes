using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class LinkedEditingRangeRegistrationOptions : TextDocumentRegistrationOptions, ILinkedEditingRangeOptions, IStaticRegistrationOptions
    {
        public LinkedEditingRangeRegistrationOptions() { }

        [DataMember(Name = "workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}
