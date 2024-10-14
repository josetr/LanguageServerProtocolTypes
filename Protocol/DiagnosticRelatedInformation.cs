using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * Represents a related message and source code location for a diagnostic.
     * This should be used to point to code locations that cause or are related to
     * a diagnostics, e.g when duplicating a symbol in a scope.
     */
    public class DiagnosticRelatedInformation
    {
        public DiagnosticRelatedInformation() { }

        /**
         * The location of this related diagnostic information.
         */
        [JsonPropertyName("location")]
        public required Location Location { get; set; }

        /**
         * The message of this related diagnostic information.
         */
        [JsonPropertyName("message")]
        public required string Message { get; set; }
    }
}
