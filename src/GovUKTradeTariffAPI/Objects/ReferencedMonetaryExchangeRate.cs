using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A monetary_exchange_rate object referenced elsewhere.
	/// </summary>
	public class ReferencedMonetaryExchangeRate
	{
		[JsonProperty("child_monetary_unit_code")]
		public int ChildMonetaryUnitCode { get; set; }

		[JsonProperty("exchange_rate")]
		public int ExchangeRate { get; set; }

		[JsonProperty("operation_date")]
		public string OperationDate { get; set; }

		[JsonProperty("validity_start_date")]
		public int ValidityStartDate { get; set; }
	}
}
