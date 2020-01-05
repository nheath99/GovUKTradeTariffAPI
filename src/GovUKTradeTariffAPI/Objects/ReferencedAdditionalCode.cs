using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// An additional_code object referenced elsewhere.
	/// </summary>
	public class ReferencedAdditionalCode
	{
		[JsonProperty("additional_code_type_id")]
		public string AdditionalCodeTypeId { get; set; }

		[JsonProperty("additional_code")]
		public string AdditionalCode { get; set; }

		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("formatted_description")]
		public string FormattedDescription { get; set; }
	}
}
