using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A heading object referenced elsewhere.
	/// </summary>
	public class ReferencedHeading : IChapterIncluded
	{
		[JsonProperty("goods_nomenclature_sid")]
		public int? GoodsNomenclatureSid { get; set; }

		[JsonProperty("goods_nomenclature_item_id")]
		public string GoodsNomenclatureItemId { get; set; }

		[JsonProperty("declarable")]
		public bool? Declarable { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("producline_suffix")]
		public string ProduclineSuffix { get; set; }

		[JsonProperty("leaf")]
		public bool? Leaf { get; set; }

		[JsonProperty("description_plain")]
		public string DescriptionPlain { get; set; }

		[JsonProperty("formatted_description")]
		public string FormattedDescription { get; set; }

		[JsonProperty("bti_url")]
		public string BtiUrl { get; set; }
	}
}
