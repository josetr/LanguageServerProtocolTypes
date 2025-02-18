﻿using System.Runtime.Serialization;

namespace LspTypes
{
    public class ShowMessageParams
    {
        public ShowMessageParams() { }

        /**
         * The message type. See {@link MessageType}.
         */
        [JsonPropertyName("type")]
        public MessageType MessageType { get; set; }

        /**
         * The actual message.
         */
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
