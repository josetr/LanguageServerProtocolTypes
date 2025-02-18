﻿using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    public class ExecuteCommandClientCapabilities
    {
        public ExecuteCommandClientCapabilities() { }

        /**
         * Execute command supports dynamic registration.
         */
        [JsonPropertyName("dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }
    }
}