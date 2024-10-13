using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class RenameRegistrationOptions : TextDocumentRegistrationOptions, IRenameOptions
    {
        public RenameRegistrationOptions() : base() { }

        [DataMember(Name = "prepareProvider")]
        public bool? PrepareProvider { get; set; }

        [DataMember(Name = "workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
