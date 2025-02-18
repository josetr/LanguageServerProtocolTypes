﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Client capabilities specific to the used markdown parser.
     *
     * @since 3.16.0
     */
    public class MarkdownClientCapabilities
    {
        public MarkdownClientCapabilities() { }

        /**
	     * The name of the parser.
	     */
        [JsonPropertyName("parser")]
        public required string Parser { get; set; }

        /**
	     * The version of the parser.
	     */
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
