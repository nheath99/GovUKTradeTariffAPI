using System;
using Newtonsoft.Json;

namespace GovUKTradeTariffAPI
{
	/// <summary>
	/// A definition object referenced elsewhere.
	/// </summary>
	public class ReferencedDefinition
	{
		[JsonProperty("quota_definition_sid")]
		public int? QuotaDefinitionSid { get; set; }

		[JsonProperty("quota_order_number_id")]
		public string QuotaOrderNumberId { get; set; }

		[JsonProperty("initial_volume")]
		public string InitialVolume { get; set; }

		[JsonProperty("validity_start_date")]
		public DateTimeOffset? ValidityStartDate { get; set; }

		[JsonProperty("validity_end_date")]
		public DateTimeOffset? ValidityEndDate { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("balance")]
		public string Balance { get; set; }

		[JsonProperty("measurement_unit")]
		public string MeasurementUnit { get; set; }

		[JsonProperty("monetary_unit")]
		public string MonetaryUnit { get; set; }

		[JsonProperty("measurement_unit_qualifier")]
		public string MeasurementUnitQualifier { get; set; }

		[JsonProperty("last_allocation_date")]
		public string LastAllocationDate { get; set; }

		[JsonProperty("suspension_period_start_date")]
		public string SuspensionPeriodStartDate { get; set; }

		[JsonProperty("suspension_period_end_date")]
		public string SuspensionPeriodEndDate { get; set; }

		[JsonProperty("blocking_period_start_date")]
		public string BlockingPeriodStartDate { get; set; }

		[JsonProperty("blocking_period_end_date")]
		public string BlockingPeriodEndDate { get; set; }
	}
}
