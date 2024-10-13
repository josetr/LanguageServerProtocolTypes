using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class TypeDefinitionClientCapabilities
    {
        public TypeDefinitionClientCapabilities() { }

        /**
	     * Whether implementation supports dynamic registration. If this is set to
	     * `true` the client supports the new `TypeDefinitionRegistrationOptions`
	     * return value for the corresponding server capability as well.
         */
        [JsonPropertyName("dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }

        /**
         * The client supports additional metadata in the form of definition links.
         *
         * @since 3.14.0
         */
        [JsonPropertyName("linkSupport")]
        public bool? LinkSupport { get; set; }
    }
}