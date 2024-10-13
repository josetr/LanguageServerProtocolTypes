using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * A special text edit to provide an insert and a replace operation.
     *
     * @since 3.16.0
     */
    public class InsertReplaceEdit
    {
        public InsertReplaceEdit() { }

        /**
	     * The string to be inserted.
	     */
        [JsonPropertyName("newText")]
        [JsonProperty(Required = Required.Always)]
        public string NewText { get; set; }

        /**
	     * The range if the insert is requested
	     */
        [JsonPropertyName("insert")]
        [JsonProperty(Required = Required.Always)]
        public Range Insert { get; set; }

        /**
	     * The range if the replace is requested.
	     */
        [JsonPropertyName("replace")]
        [JsonProperty(Required = Required.Always)]
        public Range Replace { get; set; }
    }
}
