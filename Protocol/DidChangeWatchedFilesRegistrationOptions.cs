using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Describe options to be used when registering for file system change events.
     */
    public class DidChangeWatchedFilesRegistrationOptions
    {
        public DidChangeWatchedFilesRegistrationOptions() { }

        /**
         * The watchers to register.
         */
        [JsonPropertyName("watchers")]
        [JsonProperty(Required = Required.Always)]
        public FileSystemWatcher[] Watchers { get; set; }
    }
}
