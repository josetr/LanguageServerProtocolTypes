using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokensDeltaPartialResult
    {
        public SemanticTokensDeltaPartialResult() { }

        [DataMember(Name = "edits")]
        public SemanticTokensEdit[] Edits { get; set; }
    }
}
