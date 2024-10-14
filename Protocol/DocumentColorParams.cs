﻿using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class DocumentColorParams : WorkDoneProgressParams, IPartialResultParams
    {
        public DocumentColorParams() : base() { }

        /**
	     * The text document.
	     */
        [DataMember(Name = "textDocument")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public TextDocumentIdentifier TextDocument { get; set; }

        [DataMember(Name = "partialResultToken")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<int, string> PartialResultToken { get; set; }

    }
}
