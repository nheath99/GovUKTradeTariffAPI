using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A commodity object referenced elsewhere.
	/// </summary>
	public class ReferencedCommodity : IHeadingIncluded, ICommodityIncluded, IQuotaSearchIncluded
	{
		[JsonProperty("basic_duty_rate")]
		public string BasicDutyRate { get; set; }

		[JsonProperty("bti_url")]
		public string BTIUrl { get; set; }
		
		[JsonProperty("consigned")]
		public bool? Consigned { get; set; }

		[JsonProperty("consigned_from")]
		public string ConsignedFrom { get; set; }

		[JsonProperty("declarable")]
		public bool? Declarable { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("description_plain")]
		public string DescriptionPlain { get; set; }

		[JsonProperty("formatted_description")]
		public string FormattedDescription { get; set; }

		[JsonProperty("goods_nomenclature_item_id")]
		public string GoodsNomenclatureItemId { get; set; }

		[JsonProperty("meursing_code")]
		public bool? MeursingCode { get; set; }

		[JsonProperty("number_indents")]
		public int? NumberIndents { get; set; }

		[JsonProperty("producline_suffix")]
		public string ProduclineSuffix { get; set; }
	}
}
