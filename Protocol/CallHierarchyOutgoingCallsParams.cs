namespace LspTypes
{
    public class CallHierarchyOutgoingCallsParams : WorkDoneProgressParams, IPartialResultParams
    {
        [JsonPropertyName("item")]
        public CallHierarchyItem Item { get; set; }

        [JsonPropertyName("partialResultToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<int, string> PartialResultToken { get; set; }
    }
}
