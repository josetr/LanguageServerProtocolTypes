using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    public class HoverClientCapabilities
    {
        public HoverClientCapabilities() { }

        /**
         * Whether hover supports dynamic registration.
         */
        [JsonPropertyName("dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }

        /**
         * Client supports the follow content formats if the content
	     * property refers to a `literal of type MarkupContent`.
	     * The order describes the preferred format of the client.
         */
        [JsonPropertyName("contentFormat")]
        public MarkupKind[] ContentFormat { get; set; }
    }
}
