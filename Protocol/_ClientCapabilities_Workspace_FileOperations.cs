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
        [DataMember(Name = "dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }

        /**
		 * The client has support for sending didCreateFiles notifications.
		 */
        [DataMember(Name = "didCreate")]
        public bool? DidCreate { get; set; }

        /**
		 * The client has support for sending willCreateFiles requests.
		 */
        [DataMember(Name = "willCreate")]
        public bool? WillCreate { get; set; }

        /**
		 * The client has support for sending didRenameFiles notifications.
		 */
        [DataMember(Name = "didRename")]
        public bool? DidRename { get; set; }

        /**
	 	 * The client has support for sending willRenameFiles requests.
		 */
        [DataMember(Name = "willRename")]
        public bool? WillRename { get; set; }

        /**
		 * The client has support for sending didDeleteFiles notifications.
		 */
        [DataMember(Name = "didDelete")]
        public bool? DidDelete { get; set; }

        /**
		 * The client has support for sending willDeleteFiles requests.
		 */
        [DataMember(Name = "willDelete")]
        public bool? WillDelete { get; set; }
    }
}