using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A commodity change object referenced elsewhere.
	/// </summary>
	public class ReferencedCommodityChange
	{
		[JsonProperty("oid")]
		public int? Oid { get; set; }

		[JsonProperty("model_name")]
		public string ModelName { get; set; }

		[JsonProperty("operation")]
		public string Operation { get; set; }

		[JsonProperty("operation_date")]
		public string OperationDate { get; set; }
	}
}
