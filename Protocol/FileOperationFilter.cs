using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * A filter to describe in which file operation requests or notifications
     * the server is interested in.
     *
     * @since 3.16.0
     */
    public class FileOperationFilter
    {
        public FileOperationFilter() { }

        /**
	     * A Uri like `file` or `untitled`.
	     */
        [JsonPropertyName("scheme")]
        public string Scheme { get; set; }

        /**
	     * The actual file operation pattern.
	     */
        [JsonPropertyName("pattern")]
        [JsonProperty(Required = Required.Always)]
        public FileOperationPattern Pattern { get; set; }
    }
}
