﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class WorkspaceFoldersServerCapabilities
    {
        public WorkspaceFoldersServerCapabilities() { }

        /**
         * The server has support for workspace folders
         */
        [DataMember(Name = "supported")]
        public bool? Supported { get; set; }

        /**
         * Whether the server wants to receive workspace folder
         * change notifications.
         *
         * If a string is provided, the string is treated as an ID
         * under which the notification is registered on the client
         * side. The ID can be used to unregister for these events
         * using the `client/unregisterCapability` request.
         */
        [DataMember(Name = "changeNotifications")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, bool> ChangeNotifications { get; set; }
    }
}
