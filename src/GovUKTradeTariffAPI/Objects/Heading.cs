using System.Collections.Generic;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A heading in the tariff.
	///	A heading(or sub-heading) describes products more detail than do headings or sections.
	/// </summary>
	public class Heading
	{
		[JsonProperty("data")]
		public IEnumerable<ReferencedElement<ReferencedHeading>> Data { get; set; }

		/// <summary>
		/// Zero, one or many referenced chapter objects, referenced guide objects, or referenced commodity objects.
		/// </summary>
		public IHeadingIncluded Included { get; set; }
	}
}
