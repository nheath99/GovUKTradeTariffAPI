using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	public class ReferencedElement<T>
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("attributes")]
		public T Attributes { get; set; }
	}
}
