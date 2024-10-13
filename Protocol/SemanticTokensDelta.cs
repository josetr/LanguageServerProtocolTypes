using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokensDelta
    {
        public SemanticTokensDelta() { }

        [DataMember(Name = "resultId")]
        public string ResultId { get; set; }

        /**
	     * The semantic token edits to transform a previous result into a new
	     * result.
	     */
        [DataMember(Name = "edits")]
        public SemanticTokensEdit[] Edits { get; set; }
    }
}
