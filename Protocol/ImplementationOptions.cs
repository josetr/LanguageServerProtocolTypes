using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public interface IImplementationOptions : IWorkDoneProgressOptions
    { }

    public class ImplementationOptions : WorkDoneProgressOptions, IImplementationOptions
    {
    }
}