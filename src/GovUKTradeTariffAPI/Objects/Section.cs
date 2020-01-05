using System.Collections.Generic;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A section of the Tariff.
	/// Each section has a position, which is its numerical order within the Tariff, and a section_id, which is a unique record identifier.
	/// </summary>
	public class Section
	{
		[JsonProperty("data")]
		public IEnumerable<ReferencedSection> Data { get; set; }

		/// <summary>
		/// A collection of chapters that are included in the section referenced chapter objects.
		/// </summary>
		[JsonProperty("included")]
		public IEnumerable<ReferencedChapter> Included { get; set; }
	}
}
