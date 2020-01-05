using System.Collections.Generic;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A dated list of monetary exchange rates, from Euro (€) to GPB (£).
	/// </summary>
	public class MonetaryExchangeRates
	{
		[JsonProperty("data")]
		public IEnumerable<ReferencedElement<ReferencedMonetaryExchangeRate>> Data { get; set; }
	}
}
