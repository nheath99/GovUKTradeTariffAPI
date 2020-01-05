using System;
using System.Net.Http;
using GovUKTradeTariffAPI.HttpRequests;

namespace GovUKTradeTariffAPI
{
	public class TradeTariffApiClient
	{
		public TradeTariffApiClient(IHttpClientFactory httpClientFactory)
		{
			HttpClient = httpClientFactory.CreateClient("tradeTariffApiClient");
			HttpClient.BaseAddress = new Uri($"{BaseUrl}/{Version}/");
		}

		public const string BaseUrl = "https://www.trade-tariff.service.gov.uk/api";
		public const string Version = "v2";

		internal HttpClient HttpClient { get; private set; }

		public SectionsHttpClient Sections { get; set; }
	}
}
