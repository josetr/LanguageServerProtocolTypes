﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * MarkedString can be used to render human readable text. It is either a markdown string
     * or a code-block that provides a language and a code snippet. The language identifier
     * is semantically equal to the optional language identifier in fenced code blocks in GitHub
     * issues. See https://help.github.com/articles/creating-and-highlighting-code-blocks/#syntax-highlighting
     *
     * The pair of a language and a value is an equivalent to markdown:
     * ```${language}
     * ${value}
     * ```
     *
     * Note that markdown strings will be sanitized - that means html will be escaped.
     * @deprecated use MarkupContent instead.
     */
    public class MarkedString
    {
        public MarkedString() { }

        [JsonPropertyName("language")]
        public required string Language { get; set; }

        [JsonPropertyName("value")]
        public required string Value { get; set; }
    }
}
