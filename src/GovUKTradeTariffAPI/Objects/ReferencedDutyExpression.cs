using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
    public class ReferencedDutyExpression
    {
        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("formatted_base")]
        public string FormattedBase { get; set; }
    }
}
