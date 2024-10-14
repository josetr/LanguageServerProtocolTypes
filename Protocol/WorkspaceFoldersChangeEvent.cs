using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class WorkspaceFoldersChangeEvent
    {
        public WorkspaceFoldersChangeEvent() { }

        /**
         * The array of added workspace folders
         */
        [JsonPropertyName("added")]
        public required WorkspaceFolder[] Added { get; set; }


        /**
         * The array of the removed workspace folders
         */
        [JsonPropertyName("removed")]
        public required WorkspaceFolder[] Removed { get; set; }
    }
}
