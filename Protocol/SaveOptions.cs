using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SaveOptions
    {
        public SaveOptions() { }

        /**
         * The client is supposed to include the content on save.
         */
        [JsonPropertyName("includeText")]
        public bool? IncludeText { get; set; }
    }
}
