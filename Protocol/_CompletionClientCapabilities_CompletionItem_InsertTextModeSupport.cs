﻿using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    public class _CompletionClientCapabilities_CompletionItem_InsertTextModeSupport
    {
        public _CompletionClientCapabilities_CompletionItem_InsertTextModeSupport() { }

        [JsonPropertyName("valueSet")]
        public InsertTextMode[] ValueSet { get; set; }
    }
}