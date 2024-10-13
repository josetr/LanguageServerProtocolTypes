using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class CodeLensClientCapabilities
    {
        public CodeLensClientCapabilities() { }

        /**
         * Whether code lens supports dynamic registration.
         */
        [JsonPropertyName("dynamicRegistration")]
        public bool DynamicRegistration { get; set; }
    }
}