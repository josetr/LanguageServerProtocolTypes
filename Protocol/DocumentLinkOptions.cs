using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public interface IDocumentLinkOptions
    {
        bool? ResolveProvider { get; set; }
    }

    [DataContract]
    public class DocumentLinkOptions : WorkDoneProgressOptions, IDocumentLinkOptions
    {
        public DocumentLinkOptions() { }

        /**
         * Document links have a resolve provider as well.
         */
        [JsonPropertyName("resolveProvider")]
        public bool? ResolveProvider { get; set; }
    }
}
