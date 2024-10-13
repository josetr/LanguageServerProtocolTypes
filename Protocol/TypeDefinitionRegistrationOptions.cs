using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class TypeDefinitionRegistrationOptions : TextDocumentRegistrationOptions, ITypeDefinitionOptions, IStaticRegistrationOptions
    {
        public TypeDefinitionRegistrationOptions() { }

        [DataMember(Name = "workDoneProgress")]
        public bool? WorkDoneProgress { get; set; }

        /**
         * The id used to register the request. The id can be used to deregister
         * the request again. See also Registration#id.
         */
        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}