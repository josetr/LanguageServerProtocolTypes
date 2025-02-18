﻿namespace LspTypes
{
    public class CodeLensParams : WorkDoneProgressParams, IPartialResultParams
    {
        public CodeLensParams() { }

        /**
         * The document to request code lens for.
         */
        [JsonPropertyName("textDocument")]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
         * An optional token that a server can use to report partial results (e.g. streaming) to
         * the client.
         */
        [JsonPropertyName("partialResultToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
