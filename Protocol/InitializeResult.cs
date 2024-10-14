﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class InitializeResult
    {
        public InitializeResult() { }

        /**
         * The capabilities the language server provides.
         */
        [DataMember(Name = "capabilities")]
        [JsonProperty(Required = Required.Always)]
        public ServerCapabilities Capabilities { get; set; }

        /**
         * Information about the server.
         *
         * @since 3.15.0
         */
        [DataMember(Name = "serverInfo")]
        public _InitializeResults_ServerInfo ServerInfo { get; set; }
    }
}