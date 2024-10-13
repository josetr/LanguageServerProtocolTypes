using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class CallHierarchyRegistrationOptions : TextDocumentRegistrationOptions, ICallHierarchyOptions, IStaticRegistrationOptions
    {
        public CallHierarchyRegistrationOptions() : base() { }

        [JsonPropertyName("workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}