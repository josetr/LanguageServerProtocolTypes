using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DidChangeWatchedFilesClientCapabilities
    {
        public DidChangeWatchedFilesClientCapabilities() { }

        /**
         * Did change watched files notification supports dynamic registration.
	     * Please note that the current protocol doesn't support static
	     * configuration for file changes from the server side.
         */
        [DataMember(Name = "dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }
    }
}
