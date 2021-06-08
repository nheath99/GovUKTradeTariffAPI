using System.Collections.Generic;
using Newtonsoft.Json;
using OneOf;

namespace GovUKTradeTariffAPI
{
	public class Commodity
	{
		[JsonProperty("data")]
		public ReferencedElement<ReferencedCommodity> Data { get; set; }

		/// <summary>
		/// Zero, one or many referenced commodity objects, referenced chapter objects, referenced guide objects, referenced measure objects, referenced geographical area objects objects.
		/// </summary>
		[JsonProperty("included")]
		public List<OneOf<
			ReferencedElement<ReferencedCommodity>, 
			ReferencedElement<ReferencedChapter>, 
			ReferencedElement<ReferencedGuide>, 
			ReferencedElement<ReferencedMeasure>, 
			ReferencedElement<ReferencedSection>,
			ReferencedElement<ReferencedHeading>,
			ReferencedElement<ReferencedFootnote>,
			ReferencedElement<ReferencedDutyExpression>,
			ReferencedElement<ReferencedOther>>> Included { get; set; }
	}
}
