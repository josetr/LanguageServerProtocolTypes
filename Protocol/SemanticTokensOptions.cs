using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokensOptions : WorkDoneProgressOptions, ISemanticTokensOptions
    {
        [JsonPropertyName("legend")]
        public SemanticTokensLegend Legend { get; set; }

        [JsonPropertyName("range")]
        public SumType<bool, object> Range { get; set; }

        [JsonPropertyName("full")]
        public SumType<bool, object> Full { get; set; }
    }

    public interface ISemanticTokensOptions : IWorkDoneProgressOptions
    {
        SemanticTokensLegend Legend { get; set; }

        SumType<bool, object> Range { get; set; }

        SumType<bool, object> Full { get; set; }
    }
}
