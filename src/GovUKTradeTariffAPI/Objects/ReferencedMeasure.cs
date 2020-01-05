using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A measure object referenced elsewhere.
	/// </summary>
	public class ReferencedMeasure : IFootnoteSearchIncluded, IHeadingChangesIncluded, ICommodityIncluded, ICommodityChangesIncluded, IQuotaSearchIncluded, IAdditionalCodeSearchIncluded, ICertificateSearchIncluded
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("origin")]
		public string Origin { get; set; }

		[JsonProperty("effective_start_date")]
		public string EffectiveStartDate { get; set; }

		[JsonProperty("effective_end_date")]
		public string EffectiveEndDate { get; set; }

		[JsonProperty("import")]
		public string Import { get; set; }

		[JsonProperty("excise")]
		public string Excise { get; set; }

		[JsonProperty("vat")]
		public bool? VAT { get; set; }

		[JsonProperty("producline_suffix")]
		public bool? ProduclineSuffix { get; set; }

		[JsonProperty("parent_sid")]
		public bool? ParentSid { get; set; }
	}
}
