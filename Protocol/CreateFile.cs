using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * Create file operation
     */
    public class CreateFile
    {
        public CreateFile() { }

        /**
         * A create
         */
        [JsonPropertyName("kind")]
        public required string Kind { get; set; }

        /**
         * The resource to create.
         */
        [JsonPropertyName("uri")]
        public required string Uri { get; set; }

        /**
         * Additional options
         */
        [JsonPropertyName("options")]
        public CreateFileOptions Options { get; set; }

        /**
         * An optional annotation identifer describing the operation.
         *
         * @since 3.16.0
         */
        [JsonPropertyName("annotationId")]
        public string AnnotationId { get; set; }
    }
}
