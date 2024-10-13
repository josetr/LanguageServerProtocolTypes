using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class CodeActionOptions : WorkDoneProgressOptions, ICodeActionOptions
    {
        public CodeActionOptions() : base() { }

        /**
         * CodeActionKinds that this server may return.
         *
         * The list of kinds may be generic, such as `CodeActionKind.Refactor`,
	     * or the server may list out every specific kind they provide.
         */
        [JsonPropertyName("codeActionKinds")]
        public CodeActionKind[] CodeActionKinds { get; set; }

        /**
         * The server provides support to resolve additional
         * information for a code action.
         *
         * @since 3.16.0
         */
        [JsonPropertyName("resolveProvider")]
        public bool? ResolveProvider { get; set; }
    }

    public interface ICodeActionOptions : IWorkDoneProgressOptions
    {
        CodeActionKind[] CodeActionKinds { get; set; }
    }
}
