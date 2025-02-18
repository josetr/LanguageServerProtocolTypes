﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class FileSystemWatcher
    {
        public FileSystemWatcher() { }

        /**
         * The  glob pattern to watch.
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
	     *   (e.g., `example.[!0-9]` to match on `example.a`, `example.b`, but not
	     *   `example.0`)
	     */
        [JsonPropertyName("globPattern")]
        public required string GlobPattern { get; set; }

        /**
         * The kind of events of interest. If omitted it defaults
         * to WatchKind.Create | WatchKind.Change | WatchKind.Delete
         * which is 7.
         */
        [JsonPropertyName("kind")]
        public uint? Kind { get; set; }
    }
}
