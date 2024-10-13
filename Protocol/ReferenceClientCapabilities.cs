using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class ReferenceClientCapabilities
    {
        public ReferenceClientCapabilities() { }

        /**
         * Whether references supports dynamic registration.
         */
        [JsonPropertyName("dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }
    }
}