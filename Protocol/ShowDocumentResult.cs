﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * The result of an show document request.
     *
     * @since 3.16.0
     */
    public class ShowDocumentResult
    {
        public ShowDocumentResult() { }

        /**
	     * A boolean indicating if the show was successful.
	     */
        [JsonPropertyName("success")]
        public required bool Success { get; set; }
    }
}
