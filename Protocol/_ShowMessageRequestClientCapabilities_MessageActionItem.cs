using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class _ShowMessageRequestClientCapabilities_MessageActionItem
    {
        public _ShowMessageRequestClientCapabilities_MessageActionItem() { }

        /**
		 * Whether the client supports additional attributes which
		 * are preserved and sent back to the server in the
		 * request's response.
		 */
        [JsonPropertyName("additionalPropertiesSupport")]
        public bool? AdditionalPropertiesSupport { get; set; }
    }
}
