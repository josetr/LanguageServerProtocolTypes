using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class _CompletionClientCapabilities_CompletionItem_InsertTextModeSupport
    {
        public _CompletionClientCapabilities_CompletionItem_InsertTextModeSupport() { }

        [DataMember(Name = "valueSet")]
        public InsertTextMode[] ValueSet { get; set; }
    }
}