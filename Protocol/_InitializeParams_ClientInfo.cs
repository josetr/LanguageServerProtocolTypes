﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class _InitializeParams_ClientInfo
    {
        public _InitializeParams_ClientInfo() { }

        /**
         * The name of the client as defined by the client.
         */
        [DataMember(Name = "name")]
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }

        /**
         * The client's version as defined by the client.
         */
        [DataMember(Name = "version")]
        public string Version { get; set; }
    }
}
