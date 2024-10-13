using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    [DataContract]
    public class ExecuteCommandClientCapabilities
    {
        public ExecuteCommandClientCapabilities() { }

        /**
         * Execute command supports dynamic registration.
         */
        [DataMember(Name = "dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }
    }
}