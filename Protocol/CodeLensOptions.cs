using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class CodeLensOptions : WorkDoneProgressOptions
    {
        public CodeLensOptions() { }

        /**
         * Code lens has a resolve provider as well.
         */
        [JsonPropertyName("resolveProvider")]
        public bool? ResolveProvider { get; set; }
    }

    public interface ICodeLensOptions : IWorkDoneProgressOptions
    {
        bool? ResolveProvider { get; set; }
    }

}
