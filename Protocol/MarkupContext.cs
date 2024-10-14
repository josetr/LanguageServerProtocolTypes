﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * A `MarkupContent` literal represents a string value which content is
     * interpreted base on its kind flag. Currently the protocol supports
     * `plaintext` and `markdown` as markup kinds.
     *
     * If the kind is `markdown` then the value can contain fenced code blocks like
     * in GitHub issues.
     *
     * Here is an example how such a string can be constructed using
     * JavaScript / TypeScript:
     * ```typescript
     * let markdown: MarkdownContent = {
     *  kind: MarkupKind.Markdown,
     *	value: [
     *		'# Header',
     *		'Some text',
     *		'```typescript',
     *		'someCode();',
     *		'```'
     *	].join('\n')
     * };
     * ```
     *
     * *Please Note* that clients might sanitize the return markdown. A client could
     * decide to remove HTML from the markdown to avoid script execution.
     */
    [DataContract]
    public class MarkupContent
    {
        public MarkupContent() { }

        /**
         * The type of the Markup
         */
        [JsonPropertyName("kind")]
        [JsonProperty(Required = Required.Always)]
        public MarkupKind Kind { get; set; }

        /**
         * The content itself
         */
        [JsonPropertyName("value")]
        [JsonProperty(Required = Required.Always)]
        public string Value { get; set; }
    }
}
