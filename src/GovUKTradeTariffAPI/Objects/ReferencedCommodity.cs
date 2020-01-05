using Newtonsoft.Json;

namespace GovUKTradeTariffAPI.Objects
{
	/// <summary>
	/// A commodity object referenced elsewhere.
	/// </summary>
	public class ReferencedCommodity
	{
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("number_indents")]
		public int? NumberIndents { get; set; }

		[JsonProperty("goods_nomenclature_item_id")]
		public string GoodsNomenclatureItemId { get; set; }

		[JsonProperty("leaf")]
		public bool? Leaf { get; set; }

		[JsonProperty("goods_nomenclature_sid")]
		public int? GoodsNomenclatureSid { get; set; }

		[JsonProperty("formatted_description")]
		public string FormattedDescription { get; set; }

		[JsonProperty("description_plain")]
		public string DescriptionPlain { get; set; }

		[JsonProperty("producline_suffix")]
		public string ProduclineSuffix { get; set; }

		[JsonProperty("parent_sid")]
		public string ParentSid { get; set; }
	}
}
