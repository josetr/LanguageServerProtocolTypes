using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentRangeFormattingClientCapabilities
    {
        public DocumentRangeFormattingClientCapabilities() { }

        /**
         * Whether formatting supports dynamic registration.
         */
        [DataMember(Name = "dynamicRegistration")]
        public bool DynamicRegistration { get; set; }
    }
}