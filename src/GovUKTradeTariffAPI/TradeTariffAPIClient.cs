using System;
using System.Net.Http;
using GovUKTradeTariffAPI.HttpClients;

namespace GovUKTradeTariffAPI
{
	public class TradeTariffApiClient
	{
		public TradeTariffApiClient(IHttpClientFactory httpClientFactory)
		{
			HttpClientFactory = httpClientFactory;
		}

		public const string BaseUrl = "https://www.trade-tariff.service.gov.uk/api";
		public const string Version = "v2";

		internal IHttpClientFactory HttpClientFactory { get; private set; }

		public SectionsHttpClient Sections => new SectionsHttpClient(GenerateClient());

		private HttpClient GenerateClient()
		{
			var client = HttpClientFactory.CreateClient();
			
			client.BaseAddress = new Uri($"{BaseUrl}/{Version}/");

			return client;
		}
	}
}
