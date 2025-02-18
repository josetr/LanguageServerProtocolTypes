﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public interface ITextDocumentRegistrationOptions
    {
        DocumentFilter[] DocumentSelector { get; set; }
    }

    public class TextDocumentRegistrationOptions : ITextDocumentRegistrationOptions
    {
        public TextDocumentRegistrationOptions() { }

        /**
         * A document selector to identify the scope of the registration. If set to
	     * null the document selector provided on the client side will be used.
         */
        [JsonPropertyName("documentSelector")]
        public required DocumentFilter[] DocumentSelector { get; set; }
    }
}
