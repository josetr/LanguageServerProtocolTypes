using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokensDeltaPartialResult
    {
        public SemanticTokensDeltaPartialResult() { }

        [JsonPropertyName("edits")]
        public SemanticTokensEdit[] Edits { get; set; }
    }
}
