using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class VersionedTextDocumentIdentifier : TextDocumentIdentifier
    {
        public VersionedTextDocumentIdentifier() { }

        /**
         * The version number of this document.
	     *
	     * The version number of a document will increase after each change,
	     * including undo/redo. The number doesn't need to be consecutive.
         */
        [JsonPropertyName("version")]
        public required int Version { get; set; }
    }
}
