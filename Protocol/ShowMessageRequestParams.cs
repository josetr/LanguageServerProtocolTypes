using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class ShowMessageRequestParams
    {
        public ShowMessageRequestParams() { }

        /**
         * The message type. See {@link MessageType}
         */
        [JsonPropertyName("type")]
        public int Type { get; set; }

        /**
         * The actual message
         */
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /**
         * The message action items to present.
         */
        [JsonPropertyName("actions")]
        public MessageActionItem[] Actions { get; set; }
    }
}
