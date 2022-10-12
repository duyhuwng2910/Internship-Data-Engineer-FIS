using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_County_Quarter_PlanDAO
    {
        public long Id { get; set; }
        public long? CountyId { get; set; }
        public long? QuarterKey { get; set; }
        public decimal? RevenuePlan { get; set; }
        public decimal? QuantityPlan { get; set; }
    }
}
