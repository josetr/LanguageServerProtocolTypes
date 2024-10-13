using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class WorkDoneProgressOptions : IWorkDoneProgressOptions
    {
        public WorkDoneProgressOptions() { }

        [JsonPropertyName("workDoneProgress")]
        public bool? WorkDoneProgress { get; set; } = false;
    }

    public interface IWorkDoneProgressOptions
    {
        bool? WorkDoneProgress { get; set; }
    }
}
