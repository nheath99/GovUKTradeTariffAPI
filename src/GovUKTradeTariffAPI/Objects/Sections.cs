using System.Collections.Generic;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// The response will be a JSONCollection, and will contain an array of referenced section objects, which are abbreviated versions of a full section object.
	/// </summary>
	public class Sections
	{
		public IEnumerable<ReferencedSection> Data { get; set; }
	}
}
