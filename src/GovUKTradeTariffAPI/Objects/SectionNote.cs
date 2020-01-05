using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A note associated with a section of the Tariff.
	/// A note provides textual about the section.Not all sections have a section note.
	/// </summary>
	public class SectionNote
	{
		/// <summary>
		/// The id of the section_note.
		/// </summary>
		[JsonProperty("id")]
		public int Id { get; set; }

		/// <summary>
		/// The section_id of the sction_note. It may be used to uniquely identify a section_note and request it from the API.
		/// </summary>
		[JsonProperty("section_id")]
		public int? SectionId { get; set; }

		/// <summary>
		/// The content of the section_note. Not all sections have a note.
		/// </summary>
		[JsonProperty("content")]
		public string Content { get; set; }
	}
}
