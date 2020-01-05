using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A geographical_area object referenced elsewhere.
	/// </summary>
	public class ReferencedGeographicalArea
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("geographical_area_id")]
		public string GeographicalAreaId { get; set; }
	}
}
