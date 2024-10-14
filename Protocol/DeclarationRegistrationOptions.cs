﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DeclarationRegistrationOptions : DeclarationOptions, ITextDocumentRegistrationOptions, IStaticRegistrationOptions
    {
        public DeclarationRegistrationOptions() { }

        /**
         * A document selector to identify the scope of the registration. If set to null
         * the document selector provided on the client side will be used.
         */
        [JsonPropertyName("documentSelector")]
        [JsonProperty(Required = Required.Always)]
        public DocumentFilter[] DocumentSelector { get; set; }

        /**
         * The id used to register the request. The id can be used to deregister
         * the request again. See also Registration#id.
         */
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}