using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DefinitionClientCapabilities
    {
        public DefinitionClientCapabilities() { }

        /**
         * Whether definition supports dynamic registration.
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