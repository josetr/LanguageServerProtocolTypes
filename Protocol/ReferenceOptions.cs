using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class ReferenceOptions : WorkDoneProgressOptions
    {
        public ReferenceOptions() { }
    }

    public interface IReferenceOptions : IWorkDoneProgressOptions
    {
    }
}