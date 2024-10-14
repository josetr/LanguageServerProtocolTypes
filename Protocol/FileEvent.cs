using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * An event describing a file change.
     */
    public class FileEvent
    {
        public FileEvent() { }

        /**
         * The file's URI.
         */
        [JsonPropertyName("uri")]
        public required string Uri { get; set; }

        /**
         * The change type.
         */
        [JsonPropertyName("type")]
        public required FileChangeType FileChangeType { get; set; }
    }
}
