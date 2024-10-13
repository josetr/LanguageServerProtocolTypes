using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public interface IFoldingRangeOptions : IWorkDoneProgressOptions
    {
    }

    public class FoldingRangeOptions : WorkDoneProgressOptions
    {
        public FoldingRangeOptions() { }
    }
}