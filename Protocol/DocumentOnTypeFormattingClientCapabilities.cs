﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DocumentOnTypeFormattingClientCapabilities
    {
        public DocumentOnTypeFormattingClientCapabilities() { }

        /**
         * Whether on type formatting supports dynamic registration.
         */
        [JsonPropertyName("dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }
    }
}