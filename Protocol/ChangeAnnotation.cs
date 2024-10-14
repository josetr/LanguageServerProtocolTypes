using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
	 * Additional information that describes document changes.
	 *
	 * @since 3.16.0
	 */
    public class ChangeAnnotation
    {
        /**
		 * A human-readable string describing the actual change. The string
		 * is rendered prominent in the user interface.
		 */
        [JsonPropertyName("label")]
        public required string Label { get; set; }

        /**
		 * A flag which indicates that user confirmation is needed
		 * before applying the change.
		 */
        [JsonPropertyName("needsConfirmation")]
        public bool? NeedsConfirmation { get; set; }

        /**
		 * A human-readable string which is rendered less prominent in
		 * the user interface.
		 */
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
