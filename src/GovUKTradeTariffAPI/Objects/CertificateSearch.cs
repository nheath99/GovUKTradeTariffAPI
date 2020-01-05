using System.Collections.Generic;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// Search for certificates with parameters.
	/// </summary>
	public class CertificateSearch
	{
		[JsonProperty("data")]
		public ReferencedElement<ReferencedCertificate> Data { get; set; }

		[JsonProperty("meta")]
		public Meta Meta { get; set; }

		[JsonProperty("included")]
		public IEnumerable<ICertificateSearchIncluded> Included { get; set; }
	}
}
