using System.Collections.Generic;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// An array of objects, which contain a reference to a full chapter object.
	/// Each chapter has a goods_nomenclature_item_id, which is a unique identifier.
	/// </summary>
	public class Chapters
	{
		[JsonProperty("data")]
		public IEnumerable<ReferencedElement<ReferencedChapter>> Data { get; set; }
	}
}
