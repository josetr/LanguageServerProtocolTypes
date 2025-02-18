﻿using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * The parameters sent in notifications/requests for user-initiated deletes
     * of files.
     *
     * @since 3.16.0
     */
    public class DeleteFilesParams
    {
        public DeleteFilesParams() { }

        /**
	     * An array of all files/folders deleted in this operation.
	     */
        [JsonPropertyName("files")]
        public required FileDelete[] Files { get; set; }
    }
}
