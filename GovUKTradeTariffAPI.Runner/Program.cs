using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI.Runner
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                var baseUrl = "https://www.trade-tariff.service.gov.uk/api/v2";

                var url = $"{baseUrl}/commodities/7321890000";

                var result = await client.GetAsync(url);

                if (result.IsSuccessStatusCode)
                {
                    var resultString = await result.Content.ReadAsStringAsync();

                    var settings = new JsonSerializerSettings()
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                    };

                    settings.Converters.Add(new JsonSerialisation.OneOfCommodityIncludedConverter());

                    var obj = JsonConvert.DeserializeObject<Commodity>(resultString, settings);

                    var dutyExpressions = obj.Included.Where(x => x.IsT7).Select(x => x.AsT7);
                    var footnotes = obj.Included.Where(x => x.IsT6).Select(x => x.AsT6);

                    var basicDutyRate = obj.Data.Attributes.BasicDutyRate;

                    Console.WriteLine($"Basic duty rate: {basicDutyRate}");

                    var basicDutyRateCandidate = basicDutyRate
                        .Replace("<span>", "")
                        .Replace("</span>", "")
                        .Replace("%", string.Empty)
                        .Trim();

                    if (decimal.TryParse(basicDutyRateCandidate, out var basicDutyRateValue))
                    {
                        Console.WriteLine($"Parsed value: '{basicDutyRateValue}'");
                    }

                    foreach (var expr in footnotes)
                    {
                        Console.WriteLine(expr.Attributes.Code);
                    }

                    foreach (var expr in dutyExpressions.Where(x => !string.IsNullOrEmpty(x.Attributes.Base)))
                    {
                        var candidate = expr.Attributes.Base
                            .Replace("%", string.Empty)
                            .Trim();

                        if (decimal.TryParse(candidate, out var dutyRate))
                        {
                            Console.WriteLine($"{expr.Attributes.Base} -> {dutyRate}");
                        }
                        else
                        {
                            Console.WriteLine($"{expr.Attributes.Base} -> unparsable");
                        }
                    }
                }
            }
        }
    }
}
