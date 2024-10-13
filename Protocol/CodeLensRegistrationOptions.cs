using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class CodeLensRegistrationOptions : TextDocumentRegistrationOptions, ICodeLensOptions
    {
        public CodeLensRegistrationOptions() { }

        /**
         * Code lens has a resolve provider as well.
         */
        [JsonPropertyName("resolveProvider")]
        public bool? ResolveProvider { get; set; }

        [JsonPropertyName("workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
