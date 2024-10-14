using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class ExecuteCommandParams : WorkDoneProgressParams
    {
        public ExecuteCommandParams() { }

        /**
         * The identifier of the actual command handler.
         */
        [JsonPropertyName("command")]
        public required string Command { get; set; }

        /**
         * Arguments that the command should be invoked with.
         */
        [JsonPropertyName("arguments")]
        public object[] Arguments { get; set; }
    }
}
