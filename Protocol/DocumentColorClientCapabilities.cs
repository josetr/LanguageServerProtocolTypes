using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DocumentColorClientCapabilities
    {
        public DocumentColorClientCapabilities() { }

        /**
         * Whether document color supports dynamic registration.
         */
        [JsonPropertyName("dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }
    }
}