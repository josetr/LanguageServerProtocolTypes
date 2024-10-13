using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CallHierarchyClientCapabilities
    {
        public CallHierarchyClientCapabilities() { }

        /**
	     * Whether implementation supports dynamic registration. If this is set to
	     * `true` the client supports the new `(TextDocumentRegistrationOptions &
	     * StaticRegistrationOptions)` return value for the corresponding server
	     * capability as well.
	     */
        [JsonPropertyName("dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }
    }
}