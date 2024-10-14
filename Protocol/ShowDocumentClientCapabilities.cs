using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Client capabilities for the show document request.
     *
     * @since 3.16.0
     */
    public class ShowDocumentClientCapabilities
    {
        public ShowDocumentClientCapabilities() { }

        /**
	     * The client has support for the show document
	     * request.
	     */
        [JsonPropertyName("support")]
        public required bool Support { get; set; }
    }
}
