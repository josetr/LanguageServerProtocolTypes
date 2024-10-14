using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class TextDocumentEdit
    {
        public TextDocumentEdit() { }

        /**
         * The text document to change.
         */
        [JsonPropertyName("textDocument")]
        public required OptionalVersionedTextDocumentIdentifier TextDocument { get; set; }

        /**
         * The edits to be applied.
      	 *
	     * @since 3.16.0 - support for AnnotatedTextEdit. This is guarded by the
	     * client capability `workspace.workspaceEdit.changeAnnotationSupport`
         */
        [JsonPropertyName("edits")]
        public required SumType<TextEdit, AnnotatedTextEdit>[] Edits { get; set; }
    }
}
