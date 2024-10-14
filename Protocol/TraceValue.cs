using System.Runtime.Serialization;

namespace LspTypes
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TraceValue
    {
        [EnumMember(Value = "off")]
        Off = 0,

        [EnumMember(Value = "message")]
        Messages = 1,

        [EnumMember(Value = "verbose")]
        Verbose = 2,
    }
}
