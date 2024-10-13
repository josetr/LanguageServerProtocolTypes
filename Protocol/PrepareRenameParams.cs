using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class PrepareRenameParams : TextDocumentPositionParams
    {
        public PrepareRenameParams() : base() { }
    }
}
