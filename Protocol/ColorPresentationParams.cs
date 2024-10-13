using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Params for the CodeActionRequest
     */
    [DataContract]
    public class ColorPresentationParams : WorkDoneProgressParams, IPartialResultParams
    {
        public ColorPresentationParams() { }

        /**
	     * The text document.
	     */
        [JsonPropertyName("textDocument")]
        [JsonProperty(Required = Required.Always)]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
	     * The color information to request presentations for.
	     */
        [JsonPropertyName("color")]
        [JsonProperty(Required = Required.Always)]
        public Color Color { get; set; }

        /**
	     * The range where the color would be inserted. Serves as a context.
	     */
        [JsonPropertyName("range")]
        [JsonProperty(Required = Required.Always)]
        public Range Range { get; set; }

        [JsonPropertyName("partialResultToken")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
