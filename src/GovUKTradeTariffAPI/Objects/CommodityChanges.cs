using System.Collections.Generic;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// All changes for a <see cref="Commodity"/>.
	/// </summary>
	public class CommodityChanges
	{
		[JsonProperty("data")]
		public ReferencedElement<ReferencedCommodityChange> Data { get; set; }


		[JsonProperty("included")]
		public IEnumerable<ICommodityChangesIncluded> Included { get; set; }
	}
}
