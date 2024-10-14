using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Params to show a document.
     *
     * @since 3.16.0
     */
    public class ShowDocumentParams
    {
        public ShowDocumentParams() { }

        /**
		 * The document uri to show.
		 */
        [JsonPropertyName("uri")]
        public required string Uri { get; set; }

        /**
		 * Indicates to show the resource in an external program.
		 * To show for example `https://code.visualstudio.com/`
		 * in the default WEB browser set `external` to `true`.
		 */
        [JsonPropertyName("external")]
        public bool? External { get; set; }

        /**
		 * An optional property to indicate whether the editor
		 * showing the document should take focus or not.
		 * Clients might ignore this property if an external
		 * program is started.
		 */
        [JsonPropertyName("takeFocus")]
        public bool? TakeFocus { get; set; }

        /**
		 * An optional selection range if the document is a text
		 * document. Clients might ignore the property if an
		 * external program is started or the file is not a text
		 * file.
		 */
        [JsonPropertyName("selection")]
        public Range Selection { get; set; }
    }
}
