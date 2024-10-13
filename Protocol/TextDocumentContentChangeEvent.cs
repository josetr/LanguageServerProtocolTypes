using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * An event describing a change to a text document. If range and rangeLength are
     * omitted the new text is considered to be the full content of the document.
     */
    public class TextDocumentContentChangeEvent
    {
        public TextDocumentContentChangeEvent() { }

        /**
         * The range of the document that changed.
         */
        [JsonPropertyName("range")]
        public Range Range { get; set; }

        /**
         * The optional length of the range that got replaced.
         *
         * @deprecated use range instead.
         */
        [JsonPropertyName("rangeLength")]
        public uint? RangeLength { get; set; }

        /**
         * The new text for the provided range.
         */
        // (or document)
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
