using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LspTypes
{
    /**
     * Delete file options
     */
    [DataContract]
    public class DeleteFileOptions
    {
        public DeleteFileOptions() { }

        /**
         * Delete the content recursively if a folder is denoted.
         */
        [DataMember(Name = "recursive")]
        public bool? Recursive { get; set; }

        /**
         * Ignore the operation if the file doesn't exist.
         */
        [DataMember(Name = "ignoreIfNotExists")]
        public bool? IgnoreIfNotExists { get; set; }
    }
}
