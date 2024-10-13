using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DefinitionClientCapabilities
    {
        public DefinitionClientCapabilities() { }

        /**
         * Whether definition supports dynamic registration.
         */
        [DataMember(Name = "dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }

        /**
         * The client supports additional metadata in the form of definition links.
         *
         * @since 3.14.0
         */
        [DataMember(Name = "linkSupport")]
        public bool? LinkSupport { get; set; }
    }
}