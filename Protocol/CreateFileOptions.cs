using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * Options to create a file.
     */
    [DataContract]
    public class CreateFileOptions
    {
        public CreateFileOptions() { }

        /**
         * Overwrite existing file. Overwrite wins over `ignoreIfExists`
         */
        [JsonPropertyName("overwrite")]
        public bool? Overwrite { get; set; }

        /**
         * Ignore if exists.
         */
        [JsonPropertyName("ignoreIfExists")]
        public bool? IgnoreIfExists { get; set; }
    }
}
