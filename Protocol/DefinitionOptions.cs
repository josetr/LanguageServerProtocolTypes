using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DefinitionOptions : WorkDoneProgressOptions, ITextDocumentRegistrationOptions, IStaticRegistrationOptions
    {
        public DefinitionOptions() { }

        [JsonPropertyName("documentSelector")]
        [JsonProperty(Required = Required.Always)]
        public DocumentFilter[] DocumentSelector { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}