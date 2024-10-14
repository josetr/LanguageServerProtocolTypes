﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DidChangeConfigurationParams
    {
        public DidChangeConfigurationParams() { }

        /**
         * The actual changed settings
         */
        [JsonPropertyName("settings")]
        [JsonProperty(Required = Required.Always)]
        public object Settings { get; set; }
    }
}
