﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class _CodeActionClientCapabilities_CodeActionLiteralSupport
    {
        public _CodeActionClientCapabilities_CodeActionLiteralSupport() { }

        /**
         * The code action kind is supported with the following value
         * set.
         */
        [JsonPropertyName("codeActionKind")]
        public _CodeActionClientCapabilities_CodeActionLiteralSupport_CodeActionKind CodeActionKind { get; set; }
    }
}