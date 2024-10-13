using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class _CompletionClientCapabilities_CompletionItem_TagSupport
    {
        public _CompletionClientCapabilities_CompletionItem_TagSupport() { }

        /**
         * The tags supported by the client.
         */
        [JsonPropertyName("valueSet")]
        public CompletionItemTag[] ValueSet { get; set; }
    }
}