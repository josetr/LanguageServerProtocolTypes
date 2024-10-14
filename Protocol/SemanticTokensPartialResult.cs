﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokensPartialResult
    {
        public SemanticTokensPartialResult() { }

        [JsonPropertyName("data")]
        public uint[] Data { get; set; }
    }
}
