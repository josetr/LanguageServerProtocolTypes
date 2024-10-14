﻿using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class RegistrationParams
    {
        public RegistrationParams() { }

        [JsonPropertyName("registrations")]
        public Registration[] Registrations { get; set; }
    }
}
