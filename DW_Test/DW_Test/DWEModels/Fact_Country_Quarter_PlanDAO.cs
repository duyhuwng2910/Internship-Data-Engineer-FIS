using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_Country_Quarter_PlanDAO
    {
        public long Id { get; set; }
        public long? CountryId { get; set; }
        public long? QuarterKey { get; set; }
        public decimal? RevenuePlan { get; set; }
    }
}
