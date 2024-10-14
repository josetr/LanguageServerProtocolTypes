﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class WorkDoneProgressReport
    {
        public WorkDoneProgressReport() { }

        [JsonPropertyName("kind")]
        [JsonProperty(Required = Required.Always)]
        public string Kind { get; set; }

        /**
         * Controls enablement state of a cancel button. This property is only valid
	 *  if a cancel button got requested in the `WorkDoneProgressStart` payload.
         *
         * Clients that don't support cancellation or don't support control the
	     * button's enablement state are allowed to ignore the setting.
         */
        [JsonPropertyName("cancellable")]
        public bool? Cancellable { get; set; }

        /**
         * Optional, more detailed associated progress message. Contains
         * complementary information to the `title`.
         *
         * Examples: "3/25 files", "project/src/module2", "node_modules/some_dep".
         * If unset, the previous progress message (if any) is still valid.
         */
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /**
         * Optional progress percentage to display (value 100 is considered 100%).
         * If not provided infinite progress is assumed and clients are allowed
         * to ignore the `percentage` value in subsequent in report notifications.
         *
         * The value should be steadily rising. Clients are free to ignore values
         * that are not following this rule. The value range is [0, 100]
         */
        [JsonPropertyName("percentage")]
        public uint? Percentage { get; set; }
    }
}
