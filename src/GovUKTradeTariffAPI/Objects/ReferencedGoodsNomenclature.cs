using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A goods_nomenclature object referenced elsewhere.
	/// </summary>
	public class ReferencedGoodsNomenclature
	{
		[JsonProperty("goods_nomenclature_item_id")]
		public string GoodsNomenclatureItemId { get; set; }

		[JsonProperty("goods_nomenclature_sid")]
		public int? GoodsNomenclatureSid { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("number_indents")]
		public int? NumberIndents { get; set; }

		[JsonProperty("productline_suffix")]
		public string ProductlineSuffix { get; set; }

		[JsonProperty("href")]
		public string Href { get; set; }
	}
}
