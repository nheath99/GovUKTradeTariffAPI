using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A footnote object referenced elsewhere.
	/// </summary>
	public class ReferencedFootnote
	{
		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("formatted_description")]
		public string FormattedDescription { get; set; }
	}
}
