using System.Collections.Generic;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	public class HeadingChanges
	{
		[JsonProperty("data")]
		public ReferencedElement<ReferencedHeadingChange> Data { get; set; }

		
		[JsonProperty("included")]
		public IEnumerable<IHeadingChangesIncluded> Included { get; set; }
	}
}
