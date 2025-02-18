﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DidChangeConfigurationClientCapabilities
    {
        public DidChangeConfigurationClientCapabilities() { }

        /**
         * Did change configuration notification supports dynamic registration.
         */
        [JsonPropertyName("dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }
    }
}
