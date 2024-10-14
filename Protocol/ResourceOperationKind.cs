using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * The kind of resource operations supported by the client.
     */
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ResourceOperationKind
    {
        /**
         * Supports creating new files and folders.
         */
        [EnumMember(Value = "create")]
        Create = 0,

        /**
         * Supports renaming existing files and folders.
         */
        [EnumMember(Value = "rename")]
        Rename = 1,

        /**
         * Supports deleting existing files and folders.
         */
        [EnumMember(Value = "delete")]
        Delete = 2,
    }
}