using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A guide object referenced elsewhere.
	/// </summary>
	public class ReferencedGuide : IHeadingIncluded, IChapterIncluded, ICommodityIncluded, IQuotaSearchIncluded
	{
		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }
	}
}
