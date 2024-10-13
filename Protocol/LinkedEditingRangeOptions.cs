using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class LinkedEditingRangeOptions : WorkDoneProgressOptions
    {
        public LinkedEditingRangeOptions() : base() { }
    }

    public interface ILinkedEditingRangeOptions : IWorkDoneProgressOptions
    {
    }
}
