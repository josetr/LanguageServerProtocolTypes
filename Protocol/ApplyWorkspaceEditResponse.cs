﻿using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /*
     * Response result for WorkspaceEdit.
     * The workspace/applyEdit request is sent from the server to the
     * client to modify resource on the client side.
     * https://microsoft.github.io/language-server-protocol/specifications/specification-3-16/#workspace_applyEdit
     */
    public class ApplyWorkspaceEditResponse
    {
        public ApplyWorkspaceEditResponse() { }

        /**
         * Indicates whether the edit was applied or not.
         */
        [JsonPropertyName("applied")]
        [JsonProperty(Required = Required.Always)]
        public bool Applied { get; set; }

        /**
         * An optional textual description for why the edit was not applied.
         * This may be used may be used by the server for diagnostic
         * logging or to provide a suitable error for a request that
         * triggered the edit.
         */
        [JsonPropertyName("failureReason")]
        public string FailureReason { get; set; }

        /**
         * Depending on the client's failure handling strategy `failedChange`
         * might contain the index of the change that failed. This property is
         * only available if the client signals a `failureHandlingStrategy`
         * in its client capabilities.
         */
        [JsonPropertyName("failedChange")]
        public uint? FailedChange { get; set; }
    }
}
