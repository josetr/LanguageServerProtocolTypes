using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class CompletionClientCapabilities
    {
        public CompletionClientCapabilities() { }

        /**
         * Whether completion supports dynamic registration.
         */
        [DataMember(Name = "dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }

        /**
         * The client supports the following `CompletionItem` specific
         * capabilities.
         */
        [DataMember(Name = "completionItem")]
        public _CompletionClientCapabilities_CompletionItem completionItem { get; set; }

        [DataMember(Name = "completionItemKind")]
        public _CompletionClientCapabilities_CompletionItemKind completionItemKind { get; set; }

        /**
         * The client supports to send additional context information for a
         * `textDocument/completion` request.
         */
        [DataMember(Name = "contextSupport")]
        public bool? ContextSupport { get; set; }
    }
}
