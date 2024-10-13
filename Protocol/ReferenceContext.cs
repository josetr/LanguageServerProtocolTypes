using System.Runtime.Serialization;

namespace LspTypes
{
    public class ReferenceContext
    {
        public ReferenceContext() { }

        /**
         * Include the declaration of the current symbol.
         */
        [JsonPropertyName("includeDeclaration")]
        public bool IncludeDeclaration { get; set; }
    }
}
