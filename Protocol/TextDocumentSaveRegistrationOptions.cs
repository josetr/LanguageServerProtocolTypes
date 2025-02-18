﻿using System.Runtime.Serialization;

namespace LspTypes
{
    public class TextDocumentSaveRegistrationOptions : TextDocumentRegistrationOptions
    {
        public TextDocumentSaveRegistrationOptions() { }

        /**
         * The client is supposed to include the content on save.
         */
        [JsonPropertyName("includeText")]
        public bool? IncludeText { get; set; }
    }
}
