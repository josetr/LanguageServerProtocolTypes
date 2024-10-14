namespace LspTypes
{
    public class CallHierarchyIncomingCallsParams : WorkDoneProgressParams, IPartialResultParams
    {
        public CallHierarchyIncomingCallsParams() : base() { }

        [JsonPropertyName("item")]
        public CallHierarchyItem Item { get; set; }

        [JsonPropertyName("partialResultToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
