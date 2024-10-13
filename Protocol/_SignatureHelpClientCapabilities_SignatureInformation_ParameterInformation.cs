using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class _SignatureHelpClientCapabilities_SignatureInformation_ParameterInformation
    {
        public _SignatureHelpClientCapabilities_SignatureInformation_ParameterInformation() { }

        /**
         * The client supports processing label offsets instead of a
         * simple label string.
         *
         * @since 3.14.0
         */
        [JsonPropertyName("labelOffsetSupport")]
        public bool? LabelOffsetSupport { get; set; }
    }
}
