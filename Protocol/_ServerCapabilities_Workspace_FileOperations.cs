using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class _ServerCapabilities_Workspace_FileOperations
    {
        public _ServerCapabilities_Workspace_FileOperations() { }

        /**
		 * The server is interested in receiving didCreateFiles
		 * notifications.
	 	 */
        [JsonPropertyName("didCreate")]
        public FileOperationRegistrationOptions DidCreate { get; set; }

        /**
		 * The server is interested in receiving willCreateFiles requests.
		 */
        [JsonPropertyName("willCreate")]
        public FileOperationRegistrationOptions WillCreate { get; set; }

        /**
		 * The server is interested in receiving didRenameFiles
		 * notifications.
		 */
        [JsonPropertyName("didRename")]
        public FileOperationRegistrationOptions DidRename { get; set; }

        /**
		 * The server is interested in receiving willRenameFiles requests.
		 */
        [JsonPropertyName("willRename")]
        public FileOperationRegistrationOptions WillRename { get; set; }

        /**
		 * The server is interested in receiving didDeleteFiles file
		 * notifications.
		 */
        [JsonPropertyName("didDelete")]
        public FileOperationRegistrationOptions DidDelete { get; set; }

        /**
		 * The server is interested in receiving willDeleteFiles file
		 * requests.
		 */
        [JsonPropertyName("willDelete")]
        public FileOperationRegistrationOptions WillDelete { get; set; }
    }
}