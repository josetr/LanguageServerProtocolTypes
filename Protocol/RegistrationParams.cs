using System.Runtime.Serialization;

namespace LspTypes
{
    public class RegistrationParams
    {
        public RegistrationParams() { }

        [JsonPropertyName("registrations")]
        public Registration[] Registrations { get; set; }
    }
}
