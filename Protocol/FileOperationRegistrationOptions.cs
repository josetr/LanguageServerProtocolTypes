﻿using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * The options to register for file operations.
     *
     * @since 3.16.0
     */
    public class FileOperationRegistrationOptions
    {
        public FileOperationRegistrationOptions() { }

        /**
	     * The actual filters.
	     */
        [JsonPropertyName("filters")]
        public required FileOperationFilter[] Filters { get; set; }
    }
}
