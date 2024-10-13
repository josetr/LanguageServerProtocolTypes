using System.Runtime.Serialization;

namespace LspTypes
{
    public class DocumentFormattingOptions : WorkDoneProgressOptions, IDocumentFormattingOptions
    {
        public DocumentFormattingOptions() { }
    }

    public interface IDocumentFormattingOptions : IWorkDoneProgressOptions
    {
    }
}
