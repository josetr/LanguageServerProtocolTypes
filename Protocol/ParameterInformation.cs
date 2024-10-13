using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace LspTypes
{
    /**
     * Represents a parameter of a callable-signature. A parameter can
     * have a label and a doc-comment.
     */
    [JsonConverter(typeof(ParameterInformationConverter))]
    public class ParameterInformation
    {
        public ParameterInformation() { }

        /**
         * The label of this parameter information.
         *
         * Either a string or an inclusive start and exclusive end offsets within
	     * its containing signature label. (see SignatureInformation.label). The
	     * offsets are based on a UTF-16 string representation as `Position` and
	     * `Range` does.
	     *
         * *Note*: a label of type string should be a substring of its containing
	     * signature label. Its intended use case is to highlight the parameter
	     * label part in the `SignatureInformation.label`.
	     */
        [JsonPropertyName("label")]
        [JsonProperty(Required = Required.Always, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, Tuple<uint, uint>> Label { get; set; }

        /**
         * The human-readable doc-comment of this parameter. Will be shown
         * in the UI but can be omitted.
         */
        [JsonPropertyName("documentation")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SumType<string, MarkupContent> Documentation { get; set; }
    }
}
