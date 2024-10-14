﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SemanticTokens
    {
        /**
         * An optional result id. If provided and clients support delta updating
         * the client will include the result id in the next semantic token request.
         * A server can then instead of computing all semantic tokens again simply
         * send a delta.
         */
        [DataMember(Name = "resultId")]
        public string ResultId { get; set; }

        [DataMember(Name = "data")]
        public uint[] Data { get; set; }
    }
}
