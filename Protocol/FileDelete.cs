using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * Represents information on a file/folder delete.
     *
     * @since 3.16.0
     */
    public class FileDelete
    {
        public FileDelete() { }

        /**
	     * A file:// URI for the location of the file/folder being deleted.
	     */
        [JsonPropertyName("uri")]
        [JsonProperty(Required = Required.Always)]
        public string Uri { get; set; }
    }
}