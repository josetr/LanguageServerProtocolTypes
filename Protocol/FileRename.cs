using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * Represents information on a file/folder rename.
     *
     * @since 3.16.0
     */
    public class FileRename
    {
        public FileRename() { }

        /**
	     * A file:// URI for the original location of the file/folder being renamed.
	     */
        [JsonPropertyName("oldUri")]
        public required string OldUri { get; set; }

        /**
	     * A file:// URI for the new location of the file/folder being renamed.
	     */
        [JsonPropertyName("newUri")]
        public required string NewUri { get; set; }
    }
}
