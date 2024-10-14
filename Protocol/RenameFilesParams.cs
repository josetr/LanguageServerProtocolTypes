﻿using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * The parameters sent in notifications/requests for user-initiated renames
     * of files.
     *
     * @since 3.16.0
     */
    public class RenameFilesParams
    {
        public RenameFilesParams() { }

        /**
	     * An array of all files/folders renamed in this operation. When a folder
	     * is renamed, only the folder will be included, and not its children.
	     */
        [JsonPropertyName("files")]
        public required FileRename[] Files { get; set; }
    }
}
