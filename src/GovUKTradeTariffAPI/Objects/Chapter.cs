using System.Collections.Generic;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A chapter in the Tariff.
	/// Each chapter has a goods_nomenclature_sid, which is a unique identifier.Each chapter has a goods_nomenclature_item_id, which is a unique identifier.
	/// </summary>
	public class Chapter
	{
		[JsonProperty("data")]
		public ReferencedElement<ReferencedChapter> Data { get; set; }

		/// <summary>
		/// Zero, one or many <see cref="ReferencedHeading"/> and <see cref="ReferencedGuide"/> child objects that are included in the chapter.
		/// </summary>
		[JsonProperty("included")]
		public IEnumerable<IChapterIncluded> Included { get; set; }
	}
}
