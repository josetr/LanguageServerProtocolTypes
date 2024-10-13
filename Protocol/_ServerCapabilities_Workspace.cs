using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class _ServerCapabilities_Workspace
    {
        public _ServerCapabilities_Workspace() { }

        /**
         * The server supports workspace folder.
         *
         * @since 3.6.0
         */
        [JsonPropertyName("workspaceFolders")]
        public WorkspaceFoldersServerCapabilities WorkspaceFolders { get; set; }

        [JsonPropertyName("fileOperations")]
        public _ServerCapabilities_Workspace_FileOperations FileOperations { get; set; }

    }
}
