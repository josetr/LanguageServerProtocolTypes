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
        [JsonProperty(Required = Required.Always)]
        public string Uri { get; set; }

        /**
         * The name of the workspace folder. Used to refer to this
         * workspace folder in the user interface.
         */
        [JsonPropertyName("name")]
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }
    }
}
