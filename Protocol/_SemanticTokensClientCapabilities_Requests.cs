﻿namespace LspTypes
{
    public class _SemanticTokensClientCapabilities_Requests
    {
        public _SemanticTokensClientCapabilities_Requests() { }

        /**
         * The client will send the `textDocument/semanticTokens/range` request
		 * if the server provides a corresponding handler.
         */
        [JsonPropertyName("range")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<bool, object> Range { get; set; }

        /**
         * The client will send the `textDocument/semanticTokens/full` request
		 * if the server provides a corresponding handler.
         */
        [JsonPropertyName("full")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<bool, object> Full { get; set; }
    }
}