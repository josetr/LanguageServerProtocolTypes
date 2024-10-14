﻿namespace LspTypes
{
    /**
     * The parameters of a Workspace Symbol Request.
     */
    public class WorkspaceSymbolParams : WorkDoneProgressParams, IPartialResultParams
    {
        public WorkspaceSymbolParams() { }

        /**
         * A query string to filter symbols by. Clients may send an empty
         * string here to request all symbols.
         */
        [JsonPropertyName("query")]
        public string Query { get; set; }

        /**
         * An optional token that a server can use to report partial results (e.g. streaming) to
         * the client.
         */
        [JsonPropertyName("partialResultToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
