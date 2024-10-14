﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class WorkDoneProgressEnd
    {
        public WorkDoneProgressEnd() { }

        [DataMember(Name = "kind")]
        [JsonProperty(Required = Required.Always)]
        public string Kind { get; set; }

        /**
         * Optional, a final message indicating to for example indicate the outcome
         * of the operation.
         */
        [DataMember(Name = "message")]
        public string Message { get; set; }
    }
}
