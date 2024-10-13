using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class _DocumentSymbolClientCapabilities_TagSupport
    {
        public _DocumentSymbolClientCapabilities_TagSupport() { }

        /**
         * The tags supported by the client.
         */
        [DataMember(Name = "valueSet")]
        public SymbolTag[] ValueSet { get; set; }
    }
}