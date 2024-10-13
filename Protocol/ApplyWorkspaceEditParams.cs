using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /*
     * Parameter for WorkspaceEdit.
     * The workspace/applyEdit request is sent from the server to the
     * client to modify resource on the client side.
     * https://microsoft.github.io/language-server-protocol/specifications/specification-3-16/#workspace_applyEdit
     */
    public class ApplyWorkspaceEditParams
    {
        public ApplyWorkspaceEditParams() { }

        /**
         * An optional label of the workspace edit. This label is
         * presented in the user interface for example on an undo
         * stack to undo the workspace edit.
         */
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /**
         * The edits to apply.
         */
        [JsonPropertyName("edit")]
        [JsonProperty(Required = Required.Always)]
        public WorkspaceEdit Edit { get; set; }
    }
}
