using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class DocumentFilter
    {
        public DocumentFilter() { }

        /**
         * A language id, like `typescript`.
         */
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /**
         * A Uri [scheme](#Uri.scheme), like `file` or `untitled`.
         */
        [JsonPropertyName("scheme")]
        public string Scheme { get; set; }

        /**
         * A glob pattern, like `*.{ts,js}`.
         *
         * Glob patterns can have the following syntax:
         * - `*` to match one or more characters in a path segment
         * - `?` to match on one character in a path segment
         * - `**` to match any number of path segments, including none
         * - `{}` to group conditions (e.g. `**​/*.{ts,js}` matches all TypeScript
	     *   and JavaScript files)
	     * - `[]` to declare a range of characters to match in a path segment
	     *   (e.g., `example.[0-9]` to match on `example.0`, `example.1`, …)
	     * - `[!...]` to negate a range of characters to match in a path segment
	     *   (e.g., `example.[!0-9]` to match on `example.a`, `example.b`, but
	     *   not `example.0`)
	     */
        [JsonPropertyName("pattern")]
        public string Pattern { get; set; }
    }
}
