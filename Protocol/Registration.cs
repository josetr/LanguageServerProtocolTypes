using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * General parameters to register for a capability.
     */
    [DataContract]
    public class Registration
    {
        public Registration() { }

        /**
         * The id used to register the request. The id can be used to deregister
         * the request again.
         */
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /**
         * The method / capability to register for.
         */
        [JsonPropertyName("method")]
        public string Method { get; set; }

        /**
         * Options necessary for the registration.
         */
        [JsonPropertyName("registerOptions")]
        public object RegisterOptions { get; set; }
    }
}
