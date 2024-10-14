using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class WorkDoneProgressParams : IWorkDoneProgressParams
    {
        public WorkDoneProgressParams() { }

        /**
         * An optional token that a server can use to report work done progress.
         */
        [JsonPropertyName("workDoneToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<string, int> WorkDoneToken { get; set; }
    }

    public interface IWorkDoneProgressParams
    {
        SumType<string, int> WorkDoneToken { get; set; }
    }
}
