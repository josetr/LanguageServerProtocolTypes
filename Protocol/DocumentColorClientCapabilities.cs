using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentColorClientCapabilities
    {
        public DocumentColorClientCapabilities() { }

        /**
         * Whether document color supports dynamic registration.
         */
        [DataMember(Name = "dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }
    }
}