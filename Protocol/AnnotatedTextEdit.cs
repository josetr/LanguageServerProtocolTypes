using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * A special text edit with an additional change annotation.
     *
     * @since 3.16.0.
     */
    public class AnnotatedTextEdit : TextEdit
    {
        public AnnotatedTextEdit() : base() { }

        /**
	     * The actual annotation identifier.
	     */
        [JsonPropertyName("annotationId")]
        [JsonProperty(Required = Required.Always)]
        public string AnnotationId { get; set; }
    }
}
