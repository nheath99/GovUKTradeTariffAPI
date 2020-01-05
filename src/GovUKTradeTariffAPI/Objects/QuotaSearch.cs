using System.Collections.Generic;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// Search for quota definitions with a variety of parameters.
	/// </summary>
	public class QuotaSearch
	{
		[JsonProperty("data")]
		public ReferencedElement<ReferencedDefinition> Data { get; set; }

		[JsonProperty("meta")]
		public Meta Meta { get; set; }

		[JsonProperty("included")]
		public IEnumerable<IQuotaSearchIncluded> Included { get; set; }
	}
}
