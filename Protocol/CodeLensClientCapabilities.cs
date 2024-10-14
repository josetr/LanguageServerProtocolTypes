﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CodeLensClientCapabilities
    {
        public CodeLensClientCapabilities() { }

        /**
         * Whether code lens supports dynamic registration.
         */
        [DataMember(Name = "dynamicRegistration")]
        public bool DynamicRegistration { get; set; }
    }
}