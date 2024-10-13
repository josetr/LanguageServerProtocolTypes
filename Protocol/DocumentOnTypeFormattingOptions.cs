using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public interface IDocumentOnTypeFormattingOptions
    {
        string FirstTriggerCharacter { get; set; }
        string[] MoreTriggerCharacter { get; set; }
    }

    public class DocumentOnTypeFormattingOptions
    {
        public DocumentOnTypeFormattingOptions() { }

        /**
         * A character on which formatting should be triggered, like `}`.
         */
        [JsonPropertyName("firstTriggerCharacter")]
        [JsonProperty(Required = Required.Always)]
        public string FirstTriggerCharacter { get; set; }

        /**
         * More trigger characters.
         */
        [JsonPropertyName("moreTriggerCharacter")]
        public string[] MoreTriggerCharacter { get; set; }
    }
}
