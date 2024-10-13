using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class SemanticTokensPartialResult
    {
        public SemanticTokensPartialResult() { }

        [JsonPropertyName("data")]
        public uint[] Data { get; set; }
    }
}
