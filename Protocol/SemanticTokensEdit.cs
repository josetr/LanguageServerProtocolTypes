using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokensEdit
    {
        public SemanticTokensEdit() { }

        /**
	     * The start offset of the edit.
	     */
        [JsonPropertyName("start")]
        [JsonProperty(Required = Required.Always)]
        public uint Start { get; set; }

        /**
	     * The count of elements to remove.
	     */
        [JsonPropertyName("deleteCount")]
        [JsonProperty(Required = Required.Always)]
        public uint DeleteCount { get; set; }

        /**
	     * The elements to insert.
	     */
        [JsonPropertyName("data")]
        public uint[] Data { get; set; }
    }
}
