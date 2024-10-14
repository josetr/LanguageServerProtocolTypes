﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class _DocumentSymbolClientCapabilities_SymbolKind
    {
        public _DocumentSymbolClientCapabilities_SymbolKind() { }

        /**
         * The symbol kind values the client supports. When this
         * property exists the client also guarantees that it will
         * handle values outside its set gracefully and falls back
         * to a default value when unknown.
         *
         * If this property is not present the client only supports
         * the symbol kinds from `File` to `Array` as defined in
         * the initial version of the protocol.
         */
        [JsonPropertyName("valueSet")]
        public SymbolKind[] ValueSet { get; set; }
    }
}
