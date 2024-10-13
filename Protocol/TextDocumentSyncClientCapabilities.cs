using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class TextDocumentSyncClientCapabilities
    {
        public TextDocumentSyncClientCapabilities() { }

        /**
         * Whether text document synchronization supports dynamic registration.
         */
        [JsonPropertyName("dynamicRegistration")]
        public bool? dynamicRegistration { get; set; }

        /**
         * The client supports sending will save notifications.
         */
        [JsonPropertyName("willSave")]
        public bool? WillSave { get; set; }

        /**
         * The client supports sending a will save request and
         * waits for a response providing text edits which will
         * be applied to the document before it is saved.
         */
        [JsonPropertyName("willSaveWaitUntil")]
        public bool? WillSaveWaitUntil { get; set; }

        /**
         * The client supports did save notifications.
         */
        [JsonPropertyName("didSave")]
        public bool? DidSave { get; set; }
    }
}
