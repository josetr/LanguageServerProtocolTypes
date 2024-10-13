using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class _CompletionClientCapabilities_CompletionItem_ResolveSupport
    {
        public _CompletionClientCapabilities_CompletionItem_ResolveSupport() { }

        /**
		 * The properties that a client can resolve lazily.
		 */
        [JsonPropertyName("properties")]
        public string[] Properties { get; set; }
    }
}