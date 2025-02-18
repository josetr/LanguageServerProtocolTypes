﻿using System.Runtime.Serialization;

namespace LspTypes
{
    public enum MessageType
    {
        /**
         * An error message.
         */
        Error = 1,

        /**
         * A warning message.
         */
        Warning = 2,

        /**
         * An information message.
         */
        Info = 3,

        /**
         * A log message.
         */
        Log = 4,
    }
}
