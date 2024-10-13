using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentOnTypeFormattingRegistrationOptions : TextDocumentRegistrationOptions, IDocumentOnTypeFormattingOptions
    {
        public DocumentOnTypeFormattingRegistrationOptions() { }

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
