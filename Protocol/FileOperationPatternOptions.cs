using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class FileOperationPatternOptions
    {
        public FileOperationPatternOptions() { }

        /**
          * The pattern should be matched ignoring casing.
          */
        [JsonPropertyName("ignoreCase")]
        public bool? IgnoreCase { get; set; }
    }
}
