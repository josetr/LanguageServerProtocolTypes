using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class ShowMessageRequestClientCapabilities
    {
        public ShowMessageRequestClientCapabilities() { }

        /**
	     * Capabilities specific to the `MessageActionItem` type.
	     */
        [JsonPropertyName("messageActionItem")]
        public _ShowMessageRequestClientCapabilities_MessageActionItem AnnotationId { get; set; }

    }
}
