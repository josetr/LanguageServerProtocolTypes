using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class ConfigurationItem
    {
        public ConfigurationItem() { }

        /**
         * The scope to get the configuration section for.
         */
        [DataMember(Name = "scopeUri")]
        public string ScopeUri { get; set; }

        /**
         * The configuration section asked for.
         */
        [DataMember(Name = "section")]
        public string Section { get; set; }
    }
}