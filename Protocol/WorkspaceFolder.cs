using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class WorkspaceFolder
    {
        public WorkspaceFolder() { }

        /**
         * The associated URI for this workspace folder.
         */
        [JsonPropertyName("uri")]
        public required string Uri { get; set; }

        /**
         * The name of the workspace folder. Used to refer to this
         * workspace folder in the user interface.
         */
        [JsonPropertyName("name")]
        public required string Name { get; set; }
    }
}
