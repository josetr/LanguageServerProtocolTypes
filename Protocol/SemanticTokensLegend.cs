using System.Runtime.Serialization;

namespace LspTypes
{
    public class SemanticTokensLegend
    {
        /**
         * The token types a server uses.
         */
        [JsonPropertyName("tokenTypes")]
        public string[] tokenTypes { get; set; }

        /**
         * The token modifiers a server uses.
         */
        [JsonPropertyName("tokenModifiers")]
        public string[] tokenModifiers { get; set; }
    }
}
