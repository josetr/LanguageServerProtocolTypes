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
        public required string NewText { get; set; }

        /**
	     * The range if the insert is requested
	     */
        [JsonPropertyName("insert")]
        public required Range Insert { get; set; }

        /**
	     * The range if the replace is requested.
	     */
        [JsonPropertyName("replace")]
        public required Range Replace { get; set; }
    }
}
