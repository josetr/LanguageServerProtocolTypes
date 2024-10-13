using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    public class RenameFile
    {
        public RenameFile() { }

        /**
         * A rename
         */
        // Must always be 'rename'.
        [JsonPropertyName("kind")]
        [JsonProperty(Required = Required.Always)]
        public string Kind { get; set; }

        /**
         * The old (existing) location.
         */
        [JsonPropertyName("oldUri")]
        [JsonProperty(Required = Required.Always)]
        public string OldUri { get; set; }

        /**
         * The new location.
         */
        [JsonPropertyName("newUri")]
        [JsonProperty(Required = Required.Always)]
        public string NewUri { get; set; }

        /**
         * Rename options.
         */
        [JsonPropertyName("options")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public RenameFileOptions Options { get; set; }

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
