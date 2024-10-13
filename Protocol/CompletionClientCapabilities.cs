using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    public class CompletionClientCapabilities
    {
        public CompletionClientCapabilities() { }

        /**
         * Whether completion supports dynamic registration.
         */
        [JsonPropertyName("dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }

        /**
         * The client supports the following `CompletionItem` specific
         * capabilities.
         */
        [JsonPropertyName("completionItem")]
        public _CompletionClientCapabilities_CompletionItem completionItem { get; set; }

        [JsonPropertyName("completionItemKind")]
        public _CompletionClientCapabilities_CompletionItemKind completionItemKind { get; set; }

        /**
         * The client supports to send additional context information for a
         * `textDocument/completion` request.
         */
        [JsonPropertyName("contextSupport")]
        public bool? ContextSupport { get; set; }
    }
}
