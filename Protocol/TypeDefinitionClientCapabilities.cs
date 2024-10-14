﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class TypeDefinitionClientCapabilities
    {
        public TypeDefinitionClientCapabilities() { }

        /**
	     * Whether implementation supports dynamic registration. If this is set to
	     * `true` the client supports the new `TypeDefinitionRegistrationOptions`
	     * return value for the corresponding server capability as well.
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