﻿using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class _CompletionClientCapabilities_CompletionItemKind
    {
        public _CompletionClientCapabilities_CompletionItemKind() { }

        /**
         * The completion item kind values the client supports. When this
         * property exists the client also guarantees that it will
         * handle values outside its set gracefully and falls back
         * to a default value when unknown.
         *
         * If this property is not present the client only supports
         * the completion items kinds from `Text` to `Reference` as defined in
         * the initial version of the protocol.
         */
        [JsonPropertyName("valueSet")]
        public CompletionItemKind[] ValueSet { get; set; }
    }
}