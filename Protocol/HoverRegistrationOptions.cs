using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class HoverRegistrationOptions : TextDocumentRegistrationOptions, IHoverOptions
    {
        [JsonPropertyName("workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }
    }
}
