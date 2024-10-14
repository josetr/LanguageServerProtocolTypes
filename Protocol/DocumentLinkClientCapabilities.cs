﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class DocumentLinkClientCapabilities
    {
        public DocumentLinkClientCapabilities() { }

        /**
         * Whether document link supports dynamic registration.
         */
        [DataMember(Name = "dynamicRegistration")]
        public bool? DynamicRegistration { get; set; }

        /**
         * Whether the client supports the `tooltip` property on `DocumentLink`.
         *
         * @since 3.15.0
         */
        [DataMember(Name = "tooltipSupport")]
        public bool? TooltipSupport { get; set; }
    }
}