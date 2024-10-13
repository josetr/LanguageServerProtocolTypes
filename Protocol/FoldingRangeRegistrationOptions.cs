using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class FoldingRangeRegistrationOptions : TextDocumentRegistrationOptions, IFoldingRangeOptions, IStaticRegistrationOptions
    {
        public FoldingRangeRegistrationOptions() { }

        [JsonPropertyName("workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }

        /**
         * The id used to register the request. The id can be used to deregister
         * the request again. See also Registration#id.
         */
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}