﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class WorkDoneProgressOptions : IWorkDoneProgressOptions
    {
        public WorkDoneProgressOptions() { }

        [DataMember(Name = "workDoneProgress")]
        public bool? WorkDoneProgress { get; set; } = false;
    }

    public interface IWorkDoneProgressOptions
    {
        bool? WorkDoneProgress { get; set; }
    }
}
