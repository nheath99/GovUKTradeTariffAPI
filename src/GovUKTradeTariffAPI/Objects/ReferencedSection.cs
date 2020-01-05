using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A section object referenced elsewhere.
	/// </summary>
	public class ReferencedSection
	{
		[JsonProperty("id")]
		public int? Id { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("numeral")]
		public string Numeral { get; set; }

		[JsonProperty("position")]
		public int? Position { get; set; }

		[JsonProperty("chapter_from")]
		public string ChapterFrom { get; set; }

		[JsonProperty("chapter_to")]
		public string ChapterTo { get; set; }

		[JsonProperty("section_note_id")]
		public int? SectionNoteId { get; set; }

		[JsonProperty("section_note")]
		public string SectionNote { get; set; }
	}
}
