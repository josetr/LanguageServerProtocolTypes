﻿using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Represents a collection of [completion items](#CompletionItem) to be
     * presented in the editor.
     */
    [DataContract]
    public class CompletionList
    {
        public CompletionList() { }

        /**
         * This list it not complete. Further typing should result in recomputing
         * this list.
         */
        [JsonPropertyName("isIncomplete")]
        public bool IsIncomplete { get; set; }

        /**
         * The completion items.
         */
        [JsonPropertyName("items")]
        public CompletionItem[] Items { get; set; }
    }
}
