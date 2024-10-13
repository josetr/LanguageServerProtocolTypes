using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokensRegistrationOptions : TextDocumentRegistrationOptions, ISemanticTokensOptions, IStaticRegistrationOptions
    {
        [JsonPropertyName("legend")]
        public SemanticTokensLegend Legend { get; set; }

        [JsonPropertyName("range")]
        public SumType<bool, object> Range { get; set; }

        [JsonPropertyName("full")]
        public SumType<bool, object> Full { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
