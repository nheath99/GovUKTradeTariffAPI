using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	public class Meta
	{
		/// <summary>
		/// Pagination info about current request.
		/// </summary>
		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; }
	}
}
