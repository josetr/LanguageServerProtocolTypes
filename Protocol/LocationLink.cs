using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LspTypes
{
    public class LocationLink
    {
        public LocationLink() { }

        /**
         * Span of the origin of this link.
         *
         * Used as the underlined span for mouse interaction. Defaults to the word range at
         * the mouse position.
         */
        [JsonPropertyName("originSelectionRange")]
        public Range OriginSelectionRange { get; set; }

        /**
         * The target resource identifier of this link.
         */
        [JsonPropertyName("targetUri")]
        [JsonProperty(Required = Required.Always)]
        public string TargetUri { get; set; }

        /**
         * The full target range of this link. If the target for example is a symbol then target range is the
         * range enclosing this symbol not including leading/trailing whitespace but everything else
         * like comments. This information is typically used to highlight the range in the editor.
         */
        [JsonPropertyName("targetRange")]
        [JsonProperty(Required = Required.Always)]
        public Range TargetRange { get; set; }

        /**
         * The range that should be selected and revealed when this link is being followed, e.g the name of a function.
         * Must be contained by the the `targetRange`. See also `DocumentSymbol#range`
         */
        [JsonPropertyName("targetSelectionRange")]
        [JsonProperty(Required = Required.Always)]
        public Range TargetSelectionRange { get; set; }
    }
}
