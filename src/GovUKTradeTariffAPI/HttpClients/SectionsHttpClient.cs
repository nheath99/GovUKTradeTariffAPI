using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI.HttpClients
{
	public class SectionsHttpClient
	{
		public SectionsHttpClient(HttpClient httpClient)
		{
			client = httpClient;
		}

		private readonly HttpClient client;

		public async Task<Sections> ListAsync()
		{
			var sections = await client.GetAsync("sections");

			if (sections.IsSuccessStatusCode)
			{
				var json = await sections.Content.ReadAsStringAsync();
				var obj = JsonConvert.DeserializeObject<Sections>(json);

				return obj;
			}
			else
			{
				return null;
			}
		}

		public async Task<Section> ListAsync(int position)
		{
			var sections = await client.GetAsync($"sections/{position}");

			if (sections.IsSuccessStatusCode)
			{
				var json = await sections.Content.ReadAsStringAsync();
				var obj = JsonConvert.DeserializeObject<Section>(json);

				return obj;
			}
			else
			{
				return null;
			}
		}

		public async Task<SectionNote> NoteAsync(int position)
		{
			var sections = await client.GetAsync($"sections/{position}/section_note");

			if (sections.IsSuccessStatusCode)
			{
				var json = await sections.Content.ReadAsStringAsync();
				var obj = JsonConvert.DeserializeObject<SectionNote>(json);

				return obj;
			}
			else
			{
				return null;
			}
		}
	}
}
