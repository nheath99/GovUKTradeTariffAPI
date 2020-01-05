using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A certificate object referenced elsewhere.
	/// </summary>
	public class ReferencedCertificate
	{
		[JsonProperty("certificate_type_code")]
		public string CertificateTypeCode { get; set; }

		[JsonProperty("certificate_code")]
		public string CertificateCode { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }
	}
}
