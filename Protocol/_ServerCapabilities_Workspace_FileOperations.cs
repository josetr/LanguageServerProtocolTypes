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
        [DataMember(Name = "didCreate")]
        public FileOperationRegistrationOptions DidCreate { get; set; }

        /**
		 * The server is interested in receiving willCreateFiles requests.
		 */
        [DataMember(Name = "willCreate")]
        public FileOperationRegistrationOptions WillCreate { get; set; }

        /**
		 * The server is interested in receiving didRenameFiles
		 * notifications.
		 */
        [DataMember(Name = "didRename")]
        public FileOperationRegistrationOptions DidRename { get; set; }

        /**
		 * The server is interested in receiving willRenameFiles requests.
		 */
        [DataMember(Name = "willRename")]
        public FileOperationRegistrationOptions WillRename { get; set; }

        /**
		 * The server is interested in receiving didDeleteFiles file
		 * notifications.
		 */
        [DataMember(Name = "didDelete")]
        public FileOperationRegistrationOptions DidDelete { get; set; }

        /**
		 * The server is interested in receiving willDeleteFiles file
		 * requests.
		 */
        [DataMember(Name = "willDelete")]
        public FileOperationRegistrationOptions WillDelete { get; set; }
    }
}