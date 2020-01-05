using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A note associated with a chapter of the Tariff.
	/// Not all chapters have a chapter note.
	/// </summary>
	public class ChapterNote
	{
		/// <summary>
		/// The id of the chapter_note. This is a unique identifier.
		/// </summary>
		[JsonProperty("id")]
		public int Id { get; set; }

		/// <summary>
		/// The chapter_id of the chapter_note.
		/// </summary>
		[JsonProperty("chapter_id")]
		public string ChapterId { get; set; }

		/// <summary>
		/// The section_id of this chapter that has this note.
		/// </summary>
		[JsonProperty("section_id")]
		public int? SectionId { get; set; }

		/// <summary>
		/// The content of the chapter_note.
		/// </summary>
		[JsonProperty("content")]
		public string Content { get; set; }
	}
}
