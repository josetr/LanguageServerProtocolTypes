using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * Create file operation
     */
    [DataContract]
    public class CreateFile
    {
        public CreateFile() { }

        /**
         * A create
         */
        [DataMember(Name = "kind")]
        [JsonProperty(Required = Required.Always)]
        public string Kind { get; set; }

        /**
         * The resource to create.
         */
        [DataMember(Name = "uri")]
        [JsonProperty(Required = Required.Always)]
        public string Uri { get; set; }

        /**
         * Additional options
         */
        [DataMember(Name = "options")]
        public CreateFileOptions Options { get; set; }

        /**
         * An optional annotation identifer describing the operation.
         *
         * @since 3.16.0
         */
        [DataMember(Name = "annotationId")]
        public string AnnotationId { get; set; }
    }
}
