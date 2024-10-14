using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * Delete file operation
     */
    public class DeleteFile
    {
        public DeleteFile() { }

        /**
         * A delete
         */
        // Must always be 'delete'.
        [JsonPropertyName("kind")]
        public required string Kind { get; set; }

        /**
         * The file to delete.
         */
        [JsonPropertyName("uri")]
        public required string Uri { get; set; }

        /**
         * Delete options.
         */
        [JsonPropertyName("options")]
        public DeleteFileOptions Options { get; set; }

        /**
         * An optional annotation identifer describing the operation.
         *
         * @since 3.16.0
         */
        [JsonPropertyName("annotationId")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string AnnotationId { get; set; }
    }
}
