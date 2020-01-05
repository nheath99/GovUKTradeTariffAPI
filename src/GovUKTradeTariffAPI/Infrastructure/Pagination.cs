using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	public class Pagination
	{
		/// <summary>
		/// The current page.
		/// </summary>
		[JsonProperty("page")]
		public int Page { get; set; }

		/// <summary>
		/// Maximum records for single page.
		/// </summary>
		[JsonProperty("per_page")]
		public int PerPage { get; set; }

		/// <summary>
		/// Count of records for current search request.
		/// </summary>
		[JsonProperty("total_count")]
		public int TotalCount { get; set; }
	}
}
