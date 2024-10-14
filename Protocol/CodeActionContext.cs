﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Contains additional diagnostic information about the context in which
     * a code action is run.
     */
    public class CodeActionContext
    {
        public CodeActionContext() { }

        /**
         * An array of diagnostics known on the client side overlapping the range
	     * provided to the `textDocument/codeAction` request. They are provided so
	     * that the server knows which errors are currently presented to the user
	     * for the given range. There is no guarantee that these accurately reflect
	     * the error state of the resource. The primary parameter
	     * to compute code actions is the provided range.
         */
        [JsonPropertyName("diagnostics")]
        public Diagnostic[] Diagnostics { get; set; }

        /**
         * Requested kind of actions to return.
         *
         * Actions not of this kind are filtered out by the client before being
	     * shown. So servers can omit computing them.
	     */
        [JsonPropertyName("only")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public CodeActionKind[] Only { get; set; }
    }
}
