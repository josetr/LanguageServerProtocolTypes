namespace LspTypes
{
    /**
     * Represents the signature of something callable. A signature
     * can have a label, like a function-name, a doc-comment, and
     * a set of parameters.
     */
    public class SignatureInformation
    {
        public SignatureInformation() { }

        /**
         * The label of this signature. Will be shown in
         * the UI.
         */
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /**
         * The human-readable doc-comment of this signature. Will be shown
         * in the UI but can be omitted.
         */
        [JsonPropertyName("documentation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<string, MarkupContent> Documentation { get; set; }

        /**
         * The parameters of this signature.
         */
        [JsonPropertyName("parameters")]
        public ParameterInformation[] Parameters { get; set; }

        /**
         * The index of the active parameter.
         *
         * If provided, this is used in place of `SignatureHelp.activeParameter`.
         *
         * @since 3.16.0
         */
        [JsonPropertyName("activeParameter")]
        public uint? ActiveParameter { get; set; }
    }
}
