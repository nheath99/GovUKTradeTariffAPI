using System.Collections.Generic;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	public class GoodsNomenclatures
	{
		[JsonProperty("data")]
		public IEnumerable<ReferencedElement<ReferencedGoodsNomenclature>> Data { get; set; }
	}
}
