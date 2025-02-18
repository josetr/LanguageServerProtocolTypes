﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class _CodeActionClientCapabilities_ResolveSupport
    {
        public _CodeActionClientCapabilities_ResolveSupport() { }

        /**
		 * The properties that a client can resolve lazily.
		*/
        [JsonPropertyName("properties")]
        public string[] Properties { get; set; }
    }
}