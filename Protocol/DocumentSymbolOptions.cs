using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DocumentSymbolOptions : WorkDoneProgressOptions
    {
        public DocumentSymbolOptions() : base() { }

        /**
		 * A human-readable string that is shown when multiple outlines trees
		 * are shown for the same document.
		 *
		 * @since 3.16.0
		 */
        [JsonPropertyName("label")]
        public string Label { get; set; }
    }

    public interface IDocumentSymbolOptions : IWorkDoneProgressOptions
    {
        string Label { get; set; }
    }
}