using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    public class SignatureHelpClientCapabilities
    {
        public SignatureHelpClientCapabilities() { }

        /**
         * Whether signature help supports dynamic registration.
         */
        [JsonPropertyName("dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }

        /**
         * The client supports the following `SignatureInformation`
         * specific properties.
         */
        [JsonPropertyName("signatureInformation")]
        public _SignatureHelpClientCapabilities_SignatureInformation SignatureInformation { get; set; }

        /**
         * The client supports to send additional context information for a
         * `textDocument/signatureHelp` request. A client that opts into
         * contextSupport will also support the `retriggerCharacters` on
         * `SignatureHelpOptions`.
         *
         * @since 3.15.0
         */
        [JsonPropertyName("contextSupport")]
        public bool? ContextSupport { get; set; }
    }
}
