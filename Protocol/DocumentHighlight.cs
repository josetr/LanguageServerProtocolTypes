﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * A document highlight is a range inside a text document which deserves
     * special attention. Usually a document highlight is visualized by changing
     * the background color of its range.
     *
     */
    public class DocumentHighlight
    {
        public DocumentHighlight() { }

        /**
         * The range this highlight applies to.
         */
        [JsonPropertyName("range")]
        public required Range Range { get; set; }

        /**
         * The highlight kind, default is DocumentHighlightKind.Text.
         */
        [JsonPropertyName("kind")]
        public DocumentHighlightKind? Kind { get; set; }
    }
}
