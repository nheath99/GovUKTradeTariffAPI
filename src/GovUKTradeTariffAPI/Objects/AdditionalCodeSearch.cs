using System.Collections.Generic;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// Search for additional_codes with parameters
	/// </summary>
	public class AdditionalCodeSearch
	{
		[JsonProperty("data")]
		public ReferencedElement<ReferencedAdditionalCode> Data { get; set; }

		[JsonProperty("meta")]
		public Meta Meta { get; set; }

		[JsonProperty("included")]
		public IEnumerable<IAdditionalCodeSearchIncluded> Included { get; set; }
	}
}
