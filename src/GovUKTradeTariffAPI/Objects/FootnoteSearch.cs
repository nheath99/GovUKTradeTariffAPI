using System.Collections.Generic;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	public class FootnoteSearch
	{
		[JsonProperty("data")]
		public IEnumerable<ReferencedElement<ReferencedFootnote>> Data { get; set; }

		/// <summary>
		/// Pagination info about current request.
		/// </summary>
		[JsonProperty("meta")]
		public Meta Meta { get; set; }

		/// <summary>
		/// Zero, one or many referenced goods_nomenclature objects, and referenced measure objects that are related to this footnote. May include parent objects.
		/// </summary>
		[JsonProperty("included")]
		public IEnumerable<IFootnoteSearchIncluded> Included { get; set; }
	}
}
