using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * General parameters to unregister a capability.
     */
    [DataContract]
    public class Unregistration
    {
        public Unregistration() { }

        /**
         * The id used to unregister the request or notification. Usually an id
         * provided during the register request.
         */
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /**
         * The method / capability to unregister for.
         */
        [JsonPropertyName("method")]
        public string Method { get; set; }
    }
}
