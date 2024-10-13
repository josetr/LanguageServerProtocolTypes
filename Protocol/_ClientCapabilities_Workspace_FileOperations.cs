using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class _ClientCapabilities_Workspace_FileOperations
    {
        public _ClientCapabilities_Workspace_FileOperations() { }

        /**
		 * Whether the client supports dynamic registration for file
		 * requests/notifications.
		 */
        [JsonPropertyName("dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }

        /**
		 * The client has support for sending didCreateFiles notifications.
		 */
        [JsonPropertyName("didCreate")]
        public bool? DidCreate { get; set; }

        /**
		 * The client has support for sending willCreateFiles requests.
		 */
        [JsonPropertyName("willCreate")]
        public bool? WillCreate { get; set; }

        /**
		 * The client has support for sending didRenameFiles notifications.
		 */
        [JsonPropertyName("didRename")]
        public bool? DidRename { get; set; }

        /**
	 	 * The client has support for sending willRenameFiles requests.
		 */
        [JsonPropertyName("willRename")]
        public bool? WillRename { get; set; }

        /**
		 * The client has support for sending didDeleteFiles notifications.
		 */
        [JsonPropertyName("didDelete")]
        public bool? DidDelete { get; set; }

        /**
		 * The client has support for sending willDeleteFiles requests.
		 */
        [JsonPropertyName("willDelete")]
        public bool? WillDelete { get; set; }
    }
}