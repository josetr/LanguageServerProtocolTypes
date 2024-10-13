using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class _CodeActionClientCapabilities_CodeActionLiteralSupport_CodeActionKind
    {
        public _CodeActionClientCapabilities_CodeActionLiteralSupport_CodeActionKind() { }

        /**
         * The code action kind values the client supports. When this
         * property exists the client also guarantees that it will
         * handle values outside its set gracefully and falls back
         * to a default value when unknown.
         */
        [JsonPropertyName("valueSet")]
        public CodeActionKind[] ValueSet { get; set; }
    }
}