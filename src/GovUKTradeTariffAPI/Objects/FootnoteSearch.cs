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
	}
}
