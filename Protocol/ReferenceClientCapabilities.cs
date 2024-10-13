﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class ReferenceClientCapabilities
    {
        public ReferenceClientCapabilities() { }

        /**
         * Whether references supports dynamic registration.
         */
        [DataMember(Name = "dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }
    }
}