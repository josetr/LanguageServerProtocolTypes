using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DocumentHighlightOptions : WorkDoneProgressOptions
    {
        public DocumentHighlightOptions() { }
    }

    public interface IDocumentHighlightOptions : IWorkDoneProgressOptions
    {
    }

}