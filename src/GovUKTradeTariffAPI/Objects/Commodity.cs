using System.Collections.Generic;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	public class Commodity
	{
		[JsonProperty("data")]
		public ReferencedElement<ReferencedCommodity> Data { get; set; }

		/// <summary>
		/// Zero, one or many referenced commodity objects, referenced chapter objects, referenced guide objects, referenced measure objects, referenced geographical area objects objects.
		/// </summary>
		[JsonProperty("included")]
		public IEnumerable<ICommodityIncluded> Included { get; set; }
	}
}
