using System.Collections.Generic;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// All changes for a chapter in the Tariff.
	/// </summary>
	public class ChapterChanges
	{
		[JsonProperty("data")]
		public ReferencedElement<ReferencedChapterChange> Data { get; set; }

		/// <summary>
		/// Zero, one or many <see cref="ReferencedMeasure"/> child objects that are included in the chapter’s changes.
		/// </summary>
		[JsonProperty("included")]
		public IEnumerable<ReferencedMeasure> Included { get; set; }
	}
}
