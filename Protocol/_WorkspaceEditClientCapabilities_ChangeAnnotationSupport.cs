using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class _WorkspaceEditClientCapabilities_ChangeAnnotationSupport
    {
        public _WorkspaceEditClientCapabilities_ChangeAnnotationSupport() { }

        /**
         * Whether the client groups edits with equal labels into tree nodes,
         * for instance all edits labelled with "Changes in Strings" would
         * be a tree node.
         */
        [JsonPropertyName("groupsOnLabel")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? GroupsOnLabel { get; set; }
    }
}