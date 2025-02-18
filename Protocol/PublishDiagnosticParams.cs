﻿using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class PublishDiagnosticParams
    {
        public PublishDiagnosticParams() { }

        /**
	     * The URI for which diagnostic information is reported.
	     */
        [JsonPropertyName("uri")]
        public required string Uri { get; set; }

        /**
	     * Optional the version number of the document the diagnostics are published
	     * for.
	     *
	     * @since 3.15.0
	     */
        [JsonPropertyName("version")]
        public uint? Version { get; set; }


        /**
	     * An array of diagnostic information items.
	     */
        [JsonPropertyName("diagnostics")]
        public required Diagnostic[] Diagnostics { get; set; }
    }
}
