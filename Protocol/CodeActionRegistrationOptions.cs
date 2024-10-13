using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CodeActionRegistrationOptions : TextDocumentRegistrationOptions, ICodeActionOptions
    {
        public CodeActionRegistrationOptions() { }

        [DataMember(Name = "codeActionKinds")]
        public CodeActionKind[] CodeActionKinds { get; set; }

        [DataMember(Name = "resolveProvider")]
        public bool? WorkDoneProgress { get; set; }
    }
}
