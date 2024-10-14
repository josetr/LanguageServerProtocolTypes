﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentOnTypeFormattingRegistrationOptions : TextDocumentRegistrationOptions, IDocumentOnTypeFormattingOptions
    {
        public DocumentOnTypeFormattingRegistrationOptions() { }

        /**
        * A character on which formatting should be triggered, like `}`.
        */
        [DataMember(Name = "firstTriggerCharacter")]
        [JsonProperty(Required = Required.Always)]
        public string FirstTriggerCharacter { get; set; }

        /**
         * More trigger characters.
         */
        [DataMember(Name = "moreTriggerCharacter")]
        public string[] MoreTriggerCharacter { get; set; }
    }
}
