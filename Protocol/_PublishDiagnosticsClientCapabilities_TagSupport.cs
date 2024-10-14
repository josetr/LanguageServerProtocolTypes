using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    public class _PublishDiagnosticsClientCapabilities_TagSupport
    {
        public _PublishDiagnosticsClientCapabilities_TagSupport() { }

        /**
         * The tags supported by the client.
         */
        [JsonPropertyName("valueSet")]
        public required DiagnosticTag[] ValueSet { get; set; }
    }
}