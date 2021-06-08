using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OneOf;

namespace GovUKTradeTariffAPI.JsonSerialisation
{
	public class OneOfCommodityIncludedConverter : Newtonsoft.Json.Converters.CustomCreationConverter<OneOf<
		ReferencedElement<ReferencedCommodity>,
		ReferencedElement<ReferencedChapter>,
		ReferencedElement<ReferencedGuide>,
		ReferencedElement<ReferencedMeasure>,
		ReferencedElement<ReferencedSection>,
		ReferencedElement<ReferencedHeading>,
		ReferencedElement<ReferencedFootnote>,
		ReferencedElement<ReferencedDutyExpression>,
		ReferencedElement<ReferencedOther>>>
	{
		public override OneOf<
			ReferencedElement<ReferencedCommodity>, 
			ReferencedElement<ReferencedChapter>, 
			ReferencedElement<ReferencedGuide>, 
			ReferencedElement<ReferencedMeasure>, 
			ReferencedElement<ReferencedSection>, 
			ReferencedElement<ReferencedHeading>, 
			ReferencedElement<ReferencedFootnote>, 
			ReferencedElement<ReferencedDutyExpression>,
			ReferencedElement<ReferencedOther>> Create(Type objectType)
		{
			throw new NotImplementedException();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var jObject = JObject.Load(reader);

			var target = Create(jObject);

			if (target.Value != null)
			{
				serializer.Populate(jObject.CreateReader(), target.Value);

				return target;
			}

			return null;
		}

		private OneOf<
			ReferencedElement<ReferencedCommodity>,
			ReferencedElement<ReferencedChapter>,
			ReferencedElement<ReferencedGuide>,
			ReferencedElement<ReferencedMeasure>,
			ReferencedElement<ReferencedSection>,
			ReferencedElement<ReferencedHeading>,
			ReferencedElement<ReferencedFootnote>,
			ReferencedElement<ReferencedDutyExpression>,
			ReferencedElement<ReferencedOther>> Create(JObject jObject)
		{
			var type = (string)jObject.Property("type");
			
			return type switch
			{
				"commodity" => new ReferencedElement<ReferencedCommodity>(),
				"chapter" => new ReferencedElement<ReferencedChapter>(),
				"guide" => new ReferencedElement<ReferencedGuide>(),
				"measure" => new ReferencedElement<ReferencedMeasure>(),
				"section" => new ReferencedElement<ReferencedSection>(),
				"heading" => new ReferencedElement<ReferencedHeading>(),
				"footnote" => new ReferencedElement<ReferencedFootnote>(),
				"duty_expression" => new ReferencedElement<ReferencedDutyExpression>(),
				_ => new ReferencedElement<ReferencedOther>(),
			};
		}
	}
}