using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Params for the CodeActionRequest
     */
    [DataContract]
    public class CodeActionParams : WorkDoneProgressParams, IPartialResultParams
    {
        public CodeActionParams() { }

        /**
         * The document in which the command was invoked.
         */
        [JsonPropertyName("textDocument")]
        public TextDocumentIdentifier TextDocument { get; set; }

        /**
         * The range for which the command was invoked.
         */
        [JsonPropertyName("range")]
        public Range Range { get; set; }

        /**
         * Context carrying additional information.
         */
        [JsonPropertyName("context")]
        public CodeActionContext Context { get; set; }

        /**
         * An optional token that a server can use to report partial results (e.g. streaming) to
         * the client.
         */
        [JsonPropertyName("partialResultToken")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
