using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class Command
    {
        public Command() { }

        /**
         * Title of the command, like `save`.
         */
        [JsonPropertyName("title")]
        [JsonProperty(Required = Required.Always)]
        public string Title { get; set; }

        /**
         * The identifier of the actual command handler.
         */
        [JsonPropertyName("command")]
        [JsonProperty(Required = Required.Always)]
        public string CommandIdentifier { get; set; }

        /**
         * Arguments that the command handler should be
         * invoked with.
         */
        [JsonPropertyName("arguments")]
        public object[] Arguments { get; set; }
    }
}
