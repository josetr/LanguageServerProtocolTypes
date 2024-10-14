using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class SemanticTokensEdit
    {
        public SemanticTokensEdit() { }

        /**
	     * The start offset of the edit.
	     */
        [JsonPropertyName("start")]
        public required uint Start { get; set; }

        /**
	     * The count of elements to remove.
	     */
        [JsonPropertyName("deleteCount")]
        public required uint DeleteCount { get; set; }

        /**
	     * The elements to insert.
	     */
        [JsonPropertyName("data")]
        public uint[] Data { get; set; }
    }
}
