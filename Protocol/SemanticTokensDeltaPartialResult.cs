using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class SemanticTokensDeltaPartialResult
    {
        public SemanticTokensDeltaPartialResult() { }

        [JsonPropertyName("edits")]
        public SemanticTokensEdit[] Edits { get; set; }
    }
}
