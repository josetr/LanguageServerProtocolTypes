using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class RenameOptions : WorkDoneProgressOptions
    {
        public RenameOptions() { }

        /**
         * Renames should be checked and tested before being executed.
         */
        [JsonPropertyName("prepareProvider")]
        public bool? PrepareProvider { get; set; }
    }

    public interface IRenameOptions : IWorkDoneProgressOptions
    {
        bool? PrepareProvider { get; set; }
    }
}
