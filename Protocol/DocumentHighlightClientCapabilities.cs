using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DocumentHighlightClientCapabilities
    {
        public DocumentHighlightClientCapabilities() { }

        /**
         * Whether document highlight supports dynamic registration.
         */
        [JsonPropertyName("dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }
    }
}