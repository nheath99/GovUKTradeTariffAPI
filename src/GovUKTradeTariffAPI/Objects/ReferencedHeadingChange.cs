using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A heading change object referenced elsewhere.
	/// </summary>
	public class ReferencedHeadingChange
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
