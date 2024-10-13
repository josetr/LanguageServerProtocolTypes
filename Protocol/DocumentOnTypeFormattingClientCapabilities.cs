using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentOnTypeFormattingClientCapabilities
    {
        public DocumentOnTypeFormattingClientCapabilities() { }

        /**
         * Whether on type formatting supports dynamic registration.
         */
        [DataMember(Name = "dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }
    }
}