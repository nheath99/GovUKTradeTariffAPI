using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A chapter object referenced elsewhere.
	/// </summary>
	public class ReferencedChapter
	{
		[JsonProperty("goods_nomenclature_item_id")]
		public string GoodsNomenclatureItemId { get; set; }

		[JsonProperty("goods_nomenclature_sid")]
		public int? GoodsNomenclatureSid { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("formatted_description")]
		public string FormattedDescription { get; set; }

		[JsonProperty("headings_from")]
		public string HeadingsFrom { get; set; }

		[JsonProperty("headings_to")]
		public string HeadingsTo { get; set; }

		[JsonProperty("chapter_note")]
		public string CchapterNote { get; set; }

		[JsonProperty("chapter_note_id")]
		public int? ChapterNoteId { get; set; }

		[JsonProperty("section_id")]
		public int? SectionId { get; set; }
	}
}
