using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class WorkspaceFoldersChangeEvent
    {
        public WorkspaceFoldersChangeEvent() { }

        /**
         * The array of added workspace folders
         */
        [JsonPropertyName("added")]
        [JsonProperty(Required = Required.Always)]
        public WorkspaceFolder[] Added { get; set; }


        /**
         * The array of the removed workspace folders
         */
        [JsonPropertyName("removed")]
        [JsonProperty(Required = Required.Always)]
        public WorkspaceFolder[] Removed { get; set; }
    }
}
