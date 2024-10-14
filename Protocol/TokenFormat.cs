using System.Runtime.Serialization;

namespace LspTypes
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TokenFormat
    {
        [EnumMember(Value = "relative")]
        Relative = 0,
    }
}