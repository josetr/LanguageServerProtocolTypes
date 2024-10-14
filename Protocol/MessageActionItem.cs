﻿using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class MessageActionItem
    {
        public MessageActionItem() { }

        /**
         * A short title like 'Retry', 'Open Log' etc.
         */
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
