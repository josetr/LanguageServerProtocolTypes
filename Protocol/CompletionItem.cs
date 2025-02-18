﻿using System.ComponentModel;

namespace LspTypes
{
    public class CompletionItem
    {
        public CompletionItem()
        {
            Kind = CompletionItemKind.Text;
            InsertTextFormat = InsertTextFormat.Plaintext;
        }

        /**
         * The label of this completion item. By default
         * also the text that is inserted when selecting
         * this completion.
         */
        [JsonPropertyName("label")]
        public required string Label { get; set; }

        /**
         * The kind of this completion item. Based of the kind
         * an icon is chosen by the editor. The standardized set
         * of available values is defined in `CompletionItemKind`.
         */
        [JsonPropertyName("kind")]
        public CompletionItemKind? Kind { get; set; }

        /**
         * Tags for this completion item.
         *
         * @since 3.15.0
         */
        [JsonPropertyName("tags")]
        public CompletionItemTag[] Tags { get; set; }

        /**
         * A human-readable string with additional information
         * about this item, like type or symbol information.
         */
        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        /**
         * A human-readable string that represents a doc-comment.
         */
        [JsonPropertyName("documentation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SumType<string, MarkupContent> Documentation { get; set; }

        /**
         * Indicates if this item is deprecated.
         *
         * @deprecated Use `tags` instead if supported.
         */
        [JsonPropertyName("deprecated")]
        public bool? Deprecated { get; set; }

        /**
         * Select this item when showing.
         *
         * *Note* that only one completion item can be selected and that the
         * tool / client decides which item that is. The rule is that the *first*
         * item of those that match best is selected.
         */
        [JsonPropertyName("preselect")]
        public bool? Preselect { get; set; }

        /**
         * A string that should be used when comparing this item
         * with other items. When `falsy` the label is used.
         */
        [JsonPropertyName("sortText")]
        public string SortText { get; set; }

        /**
         * A string that should be used when filtering a set of
         * completion items. When `falsy` the label is used.
         */
        [JsonPropertyName("filterText")]
        public string FilterText { get; set; }

        /**
         * A string that should be inserted into a document when selecting
         * this completion. When `falsy` the label is used.
         *
         * The `insertText` is subject to interpretation by the client side.
         * Some tools might not take the string literally. For example
         * VS Code when code complete is requested in this example
	     * `con<cursor position>` and a completion item with an `insertText` of
	     * `console` is provided it will only insert `sole`. Therefore it is
	     * recommended to use `textEdit` instead since it avoids additional client
	     * side interpretation.
         */
        [JsonPropertyName("insertText")]
        public string InsertText { get; set; }

        /**
         * The format of the insert text. The format applies to both the
	     * `insertText` property and the `newText` property of a provided
	     * `textEdit`. If omitted defaults to `InsertTextFormat.PlainText`.
	     */
        [JsonPropertyName("insertTextFormat")]
        [DefaultValue(InsertTextFormat.Plaintext)]
        public InsertTextFormat InsertTextFormat { get; set; }

        /**
         * How whitespace and indentation is handled during completion
         * item insertion. If not provided the client's default value depends on
         * the `textDocument.completion.insertTextMode` client capability.
         *
         * @since 3.16.0
         */
        [JsonPropertyName("insertTextMode")]
        public InsertTextMode? InsertTextMode { get; set; }

        /**
         * An edit which is applied to a document when selecting this completion.
	     * When an edit is provided the value of `insertText` is ignored.
	     *
	     * *Note:* The range of the edit must be a single line range and it must
	     * contain the position at which completion has been requested.
	     *
	     * Most editors support two different operations when accepting a completion
	     * item. One is to insert a completion text and the other is to replace an
	     * existing text with a completion text. Since this can usually not be
	     * predetermined by a server it can report both ranges. Clients need to
	     * signal support for `InsertReplaceEdits` via the
	     * `textDocument.completion.insertReplaceSupport` client capability
	     * property.
	     *
	     * *Note 1:* The text edit's range as well as both ranges from an insert
	     * replace edit must be a [single line] and they must contain the position
	     * at which completion has been requested.
	     * *Note 2:* If an `InsertReplaceEdit` is returned the edit's insert range
	     * must be a prefix of the edit's replace range, that means it must be
	     * contained and starting at the same position.
	     *
	     * @since 3.16.0 additional type `InsertReplaceEdit`
         */
        [JsonPropertyName("textEdit")]
        public SumType<TextEdit, InsertReplaceEdit>? TextEdit { get; set; }

        /**
         * An optional array of additional text edits that are applied when
	     * selecting this completion. Edits must not overlap (including the same
	     * insert position) with the main edit nor with themselves.
	     *
	     * Additional text edits should be used to change text unrelated to the
	     * current cursor position (for example adding an import statement at the
	     * top of the file if the completion item will insert an unqualified type).
	     */
        [JsonPropertyName("additionalTextEdits")]
        public TextEdit[] AdditionalTextEdits { get; set; }

        /**
         * An optional set of characters that when pressed while this completion is
	     * active will accept it first and then type that character. *Note* that all
	     * commit characters should have `length=1` and that superfluous characters
	     * will be ignored.
         */
        [JsonPropertyName("commitCharacters")]
        public string[] CommitCharacters { get; set; }

        /**
         * An optional command that is executed *after* inserting this completion.
	     * *Note* that additional modifications to the current document should be
	     * described with the additionalTextEdits-property.
         */
        [JsonPropertyName("command")]
        public Command Command { get; set; }

        /**
         * A data entry field that is preserved on a completion item between
         * a completion and a completion resolve request.
         */
        [JsonPropertyName("data")]
        public object Data { get; set; }
    }
}
