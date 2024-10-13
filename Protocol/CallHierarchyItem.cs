using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace LspTypes
{
    [DataContract]
    public class CallHierarchyItem
    {
        public CallHierarchyItem() { }

        /**
		 * The name of this item.
		 */
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /**
		 * The kind of this item.
		 */
        [DataMember(Name = "kind")]
        public SymbolKind Kind { get; set; }

        /**
		 * Tags for this item.
		 */
        [DataMember(Name = "tags")]
        public SymbolTag[] Tags { get; set; }

        /**
		 * More detail for this item, e.g. the signature of a function.
		 */
        [DataMember(Name = "detail")]
        public string Detail { get; set; }

        /**
		 * The resource identifier of this item.
		 */
        [DataMember(Name = "uri")]
        public string Uri { get; set; }

        /**
		 * The range enclosing this symbol not including leading/trailing whitespace
		 * but everything else, e.g. comments and code.
		 */
        [DataMember(Name = "range")]
        public Range Range { get; set; }

        /**
		 * The range that should be selected and revealed when this symbol is being
		 * picked, e.g. the name of a function. Must be contained by the
		 * [`range`](#CallHierarchyItem.range).
		 */
        [DataMember(Name = "selectionRange")]
        public Range SelectionRange { get; set; }

        /**
		 * A data entry field that is preserved between a call hierarchy prepare and
		 * incoming calls or outgoing calls requests.
		 */
        [DataMember(Name = "data")]
        public object Data { get; set; }
    }
}
