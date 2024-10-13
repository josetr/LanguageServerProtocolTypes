using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * An event describing a file change.
     */
    [DataContract]
    public class FileEvent
    {
        public FileEvent() { }

        /**
         * The file's URI.
         */
        [JsonPropertyName("uri")]
        [JsonProperty(Required = Required.Always)]
        public string Uri { get; set; }

        /**
         * The change type.
         */
        [JsonPropertyName("type")]
        [JsonProperty(Required = Required.Always)]
        public FileChangeType FileChangeType { get; set; }
    }
}
