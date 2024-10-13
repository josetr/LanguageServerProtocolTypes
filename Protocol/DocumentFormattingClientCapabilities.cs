using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentFormattingClientCapabilities
    {
        public DocumentFormattingClientCapabilities() { }

        /**
         * Whether document color supports dynamic registration.
         */
        [DataMember(Name = "dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }
    }
}