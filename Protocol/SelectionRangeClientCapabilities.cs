using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SelectionRangeClientCapabilities
    {
        public SelectionRangeClientCapabilities() { }

        /**
         * Whether implementation supports dynamic registration for selection range
	     * providers. If this is set to `true` the client supports the new
	     * `SelectionRangeRegistrationOptions` return value for the corresponding
	     * server capability as well.
         */
        [JsonPropertyName("dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }
    }
}