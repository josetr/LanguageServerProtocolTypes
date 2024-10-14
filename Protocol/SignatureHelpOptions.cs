﻿using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class SignatureHelpOptions : WorkDoneProgressOptions, ISignatureHelpOptions
    {
        public SignatureHelpOptions() { }

        /**
         * The characters that trigger signature help
         * automatically.
         */
        [JsonPropertyName("triggerCharacters")]
        public string[] TriggerCharacters { get; set; }

        /**
         * List of characters that re-trigger signature help.
         *
         * These trigger characters are only active when signature help is already
	     * showing. All trigger characters are also counted as re-trigger
	     * characters.
         *
         * @since 3.15.0
         */
        [JsonPropertyName("retriggerCharacters")]
        public string[] RetriggerCharacters { get; set; }
    }
}
